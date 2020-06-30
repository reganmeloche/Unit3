﻿using System;

namespace Unit3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define all the blood types
            var bloodTypeOn = new BloodType("O", '-');
            var bloodTypeOp = new BloodType("O", '+');
            var bloodTypeAn = new BloodType("A", '-');
            var bloodTypeAp = new BloodType("A", '+');
            var bloodTypeBn = new BloodType("B", '-');
            var bloodTypeBp = new BloodType("B", '+');
            var bloodTypeABn = new BloodType("AB", '-');
            var bloodTypeABp = new BloodType("AB", '+');

            // Create a donor
            var dob1 = new DateTime(1960, 2, 3);
            var donor1 = new Donor("Homer", "Simpson", dob1, bloodTypeBn);
            donor1.PrintDetails();

            // Create another donor
            var dob2 = new DateTime(1994, 11, 21);
            var donor2 = new Donor("Bart", "Simpson", dob2, bloodTypeBn);
            donor2.PrintDetails();

            // Create a receiver
            var receiver = new Receiver("Marge", "Simpson", new DateTime(1960, 4, 18), bloodTypeAp);

            donor1.TryToMakeDonation();
            donor1.TryToMakeDonation();
        }
    }
   
}
