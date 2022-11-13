using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Csla;

namespace ClinicalTrial
{
  public partial class frmClinicalTrial : Form
  {
    const int AMOUNT_OF_PATIENTS = 4;
    const int PATIENT_INITIALS_COLUMN = 0;

    private List<Patient> patients;
    private List<string> pillList;
    private int pillsAllocated;

    private List<Button> allocationButtons;
    private List<Label> pillIcons;

    public frmClinicalTrial()
    {
      InitializeComponent();
      InitalizePatients();
      InitalizeControls();
      InitalizePills();
    }

    private void InitalizePatients()
    {
      patients = new List<Patient>();
      for (int i = 0; i < AMOUNT_OF_PATIENTS; i++)
      {
        patients.Add(new Patient());
      }
    }

    public void InitalizePills()
    {
      pillsAllocated = 0;
      lblStatus.Text = "Please allocate pills to each patient.";

      pillList = new List<string>();
      pillList.Add("red");
      pillList.Add("red");
      pillList.Add("blue");
      pillList.Add("blue");
    }

    private void InitalizeControls()
    {
      var binding = new SortedBindingList<Patient>(patients);
      binding.ApplySort("DateAdded", ListSortDirection.Ascending);

      dgvPatients.DataSource = binding;
      dgvPatients.AutoGenerateColumns = true;
      dgvPatients.Sort(dgvPatients.Columns[1], ListSortDirection.Descending);

      allocationButtons = new List<Button>();
      allocationButtons.Add(btnAllocate1);
      allocationButtons.Add(btnAllocate2);
      allocationButtons.Add(btnAllocate3);
      allocationButtons.Add(btnAllocate4);

      pillIcons = new List<Label>();
      pillIcons.Add(lblPillIcon1);
      pillIcons.Add(lblPillIcon2);
      pillIcons.Add(lblPillIcon3);
      pillIcons.Add(lblPillIcon4);

      AssignAllocationButtonsToPatients();
    }

    private void AllocateButtonPress(int patientNo, Button allocateButton, Label pillIcon)
    {
      if (!ConfirmAllocation())
        return;

      string pillToAllocate = RandomPill();
      patients[patientNo].AllocatePill(pillToAllocate);
      
      foreach (DataGridViewRow row in dgvPatients.Rows)
      {
        if (row.Cells[PATIENT_INITIALS_COLUMN].Value == patients[patientNo].Initials)
        {
          row.DefaultCellStyle.BackColor = Color.Violet;
        }
      }
      
      pillsAllocated++;
      if (pillsAllocated == 4)
      {
        lblStatus.Text = "All pills allocated.";
      }

      allocateButton.Enabled = false;
      allocateButton.BackColor = Color.Black;
      allocateButton.ForeColor = Color.White;

      pillIcon.Visible = false;
    }

    private bool ConfirmAllocation()
    {
      DialogResult confirmAllocation = MessageBox.Show("Are you sure you wish to allocate to this patient?", "Confirmation", MessageBoxButtons.YesNo);
      if (confirmAllocation == DialogResult.Yes) return true;
      else return false;
    }

    private string RandomPill()
    {
      var random = new Random();
      int pillPosition = random.Next(pillList.Count);
      string pill = pillList[pillPosition];
      pillList.Remove(pill);
      return pill;
    }

    private void AssignAllocationButtonsToPatients()
    {
      btnAllocate1.Text = "Allocate " + patients[0].Initials;
      btnAllocate2.Text = "Allocate " + patients[1].Initials;
      btnAllocate3.Text = "Allocate " + patients[2].Initials;
      btnAllocate4.Text = "Allocate " + patients[3].Initials;
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
      foreach (Patient patient in patients)
      {
        patient.ResetAllocatedPill();
      }
      foreach (DataGridViewRow row in dgvPatients.Rows)
      {
        row.DefaultCellStyle.BackColor = Color.White;
      }
      InitalizePills();
      foreach (Button btn in allocationButtons)
      {
        btn.Enabled = true;
        btn.BackColor = SystemColors.Control;
        btn.ForeColor = Color.Black;
      }
      foreach (Label lbl in pillIcons)
      {
        lbl.Visible = true;
      }
    }

    private void btnAllocate1_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(0, btnAllocate1, lblPillIcon1);
    }

    private void btnAllocate2_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(1, btnAllocate2, lblPillIcon2);
    }

    private void btnAllocate3_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(2, btnAllocate3, lblPillIcon3);
    }

    private void btnAllocate4_Click(object sender, EventArgs e)
    {
      AllocateButtonPress(3, btnAllocate4, lblPillIcon4);
    }
  }
}
