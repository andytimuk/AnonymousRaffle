using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Csla;

namespace AnonymousRaffle
{
  public partial class frmAnonymousRaffle : Form
  {
    const int AMOUNT_OF_ENTRANTS = 4;
    const int ENTRANT_INITIALS_COLUMN = 0;

    private List<Entrant> entrants;
    private List<string> prizeList;
    private int prizesAllocated;

    private List<Button> allocationButtons;
    private List<Label> prizeIcons;

    public frmAnonymousRaffle()
    {
      InitializeComponent();
      InitalizeEntrants();
      InitalizeControls();
      InitalizePrizes();
    }

    private void InitalizeEntrants()
    {
      entrants = new List<Entrant>();
      for (int i = 0; i < AMOUNT_OF_ENTRANTS; i++)
      {
        entrants.Add(new Entrant());
      }
    }

    public void InitalizePrizes()
    {
      prizesAllocated = 0;
      lblStatus.Text = "Please allocate a prize to each entrant.";

      prizeList = new List<string>();
      prizeList.Add("£500");
      prizeList.Add("£50");
      prizeList.Add("£5");
      prizeList.Add("£0.50");
    }

    private void InitalizeControls()
    {
      var binding = new SortedBindingList<Entrant>(entrants);
      binding.ApplySort("DateAdded", ListSortDirection.Ascending);

      dgvEntrants.DataSource = binding;
      dgvEntrants.AutoGenerateColumns = true;
      dgvEntrants.Sort(dgvEntrants.Columns[1], ListSortDirection.Descending);

      allocationButtons = new List<Button>();
      allocationButtons.Add(btnAllocate1);
      allocationButtons.Add(btnAllocate2);
      allocationButtons.Add(btnAllocate3);
      allocationButtons.Add(btnAllocate4);

      prizeIcons = new List<Label>();
      prizeIcons.Add(lblPrizeIcon1);
      prizeIcons.Add(lblPrizeIcon2);
      prizeIcons.Add(lblPrizeIcon3);
      prizeIcons.Add(lblPrizeIcon4);

      AssignAllocationButtonsToEntrants();
    }

    private void AllocateButtonPress(int entrantNo, Button allocateButton, Label prizeIcon)
    {
      if (!ConfirmAllocation())
        return;

      string prizeToAllocate = RandomPrize();
      entrants[entrantNo].AllocatePrize(prizeToAllocate);
      
      foreach (DataGridViewRow row in dgvEntrants.Rows)
      {
        if (row.Cells[ENTRANT_INITIALS_COLUMN].Value == entrants[entrantNo].Initials)
        {
          row.DefaultCellStyle.BackColor = Color.Violet;
        }
      }
      
      prizesAllocated++;
      if (prizesAllocated == 4)
      {
        lblStatus.Text = "All prizes allocated.";
      }

      allocateButton.Enabled = false;
      allocateButton.BackColor = Color.Black;
      allocateButton.ForeColor = Color.White;

      prizeIcon.Visible = false;
    }

    private bool ConfirmAllocation()
    {
      DialogResult confirmAllocation = MessageBox.Show("Are you sure you wish to allocate to this entrant?", "Confirmation", MessageBoxButtons.YesNo);
      if (confirmAllocation == DialogResult.Yes) return true;
      else return false;
    }

    private string RandomPrize()
    {
      var random = new Random();
      int prizePosition = random.Next(prizeList.Count);
      string prize = prizeList[prizePosition];
      prizeList.Remove(prize);
      return prize;
    }

    private void AssignAllocationButtonsToEntrants()
    {
      btnAllocate1.Text = "Allocate " + entrants[0].Initials;
      btnAllocate2.Text = "Allocate " + entrants[1].Initials;
      btnAllocate3.Text = "Allocate " + entrants[2].Initials;
      btnAllocate4.Text = "Allocate " + entrants[3].Initials;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      foreach (Entrant entrant in entrants)
      {
        entrant.ResetAllocatedPrize();
      }
      foreach (DataGridViewRow row in dgvEntrants.Rows)
      {
        row.DefaultCellStyle.BackColor = Color.White;
      }
      InitalizePrizes();
      foreach (Button btn in allocationButtons)
      {
        btn.Enabled = true;
        btn.BackColor = SystemColors.Control;
        btn.ForeColor = Color.Black;
      }
      foreach (Label lbl in prizeIcons)
      {
        lbl.Visible = true;
      }
    }

    private void btnAllocate1_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(0, btnAllocate1, lblPrizeIcon1);
    }

    private void btnAllocate2_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(1, btnAllocate2, lblPrizeIcon2);
    }

    private void btnAllocate3_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(2, btnAllocate3, lblPrizeIcon3);
    }

    private void btnAllocate4_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(3, btnAllocate4, lblPrizeIcon4);
    }
  }
}
