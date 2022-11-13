using System;
using System.Threading;

namespace ClinicalTrial
{
  public class Patient
  {
    public string Initials { get { return initials; } }
    public string DateAdded { get { return dateAdded; } }
    public string DateOfBirth { get { return DOB.ToString("yyyy-MM-dd"); } }
    public string AllocatedPill { get { return allocatedPill.ToString(); } }

    public string AllocatedDate { get {
        if (allocatedDate.HasValue)
          return allocatedDate.Value.ToString("yyyy-MM-dd, H:mm");
        else
          return null;
      } 
    }

    private string initials;
    private string dateAdded;
    public DateTime DOB;
    private string allocatedPill;
    private DateTime? allocatedDate;

    public Patient()
    {
      DateTime minimumDOB = new DateTime(1922, 10, 18);
      DateTime maximumDOB = new DateTime(2004, 10, 18);
      DateTime minimumAllocatedDate = new DateTime(2022, 10, 22);

      initials = RandomizeInitials();
      DOB = RandomizeDate(minimumDOB, maximumDOB);
      dateAdded = RandomizeDate(minimumAllocatedDate, DateTime.Today).ToString("yyyy-MM-dd, H:mm");
      allocatedPill = "None";
    }

    public string RandomizeInitials()
    {
        string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        Random randInitials = new Random();
        int range = randInitials.Next(0, chars.Length);
        int range2 = randInitials.Next(0, chars.Length);
        Thread.Sleep(100); // Pause to allow new seed for next randomisation
        return chars[range].ToString() + chars[range2].ToString();
    }

    public DateTime RandomizeDate(DateTime startDate, DateTime endDate)
    {
        int range = (endDate - startDate).Days;
        int range2 = (23 - 0);
        int range3 = (59 - 0);
        Random randDate = new Random();
        DateTime finalDate = startDate.AddDays(randDate.Next(range));
        finalDate = finalDate.AddHours(randDate.Next(range2));
        finalDate = finalDate.AddMinutes(randDate.Next(range3));
        return finalDate;
    }

    public void AllocatePill(string pill)
    {
        allocatedPill = pill;
        allocatedDate = DateTime.Now;
    }

    public void ResetAllocatedPill()
    {
        allocatedPill = "None";
        allocatedDate = null;
    }
  }
}
