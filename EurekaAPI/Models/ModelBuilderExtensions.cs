using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EurekaAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Card>().HasData(
                    new Card
                    {
                        CardId = 10001,
                        Topic = "Operating System",
                        Title = "Take a screenshot in Windows 10",
                        CreatedDate = new DateTime(2021, 12, 12, 08, 00, 00),
                        Step1 = "Open Snip & Sketch tool or press Windows Key + Shift + S",
                        Step2 = "Click the menu to take a rectangular, free-form, window, or full-screen capture (from left to right)",
                        Step3 = "After you capture the screenshot, it will be saved to your clipboard",
                        Step4 = "A preview notification will appear in the lower-right corner of your screen",
                        UserId = 1
                    },
                    new Card
                    {
                        CardId = 10002,
                        Topic = "Browser",
                        Title = "Clear cache in Microsoft Edge",
                        CreatedDate = new DateTime(2021, 12, 14, 13, 00, 00),
                        Step1 = "Click on the edge (three dots) menu button situated in the upper right corner",
                        Step2 = "Click on Settings",
                        Step3 = "Under Clear browsing data, click on Choose what to clear",
                        Step4 = "Check the boxes next to Cookies and saved website data and Cached data and files",
                        Step5 = "Click on Clear",
                        UserId = 1
                    },
                    new Card
                    {
                        CardId = 10003,
                        Topic = "Personal and Spiritual Development",
                        Title = "Ways to a avoid procrastination",
                        CreatedDate = new DateTime(2021, 12, 14, 13, 00, 00),
                        Step1 = "Get Organized",
                        Step2 = "Eliminate Distractions",
                        Step3 = "Prioritize",
                        Step4 = "Set Goals",
                        Step5 = "Set Deadlines",
                        Step6 = "Take a Break",
                        Step7 = "Reward Yourself",
                        Step8 = "Hold yourself accountable",
                        UserId = 2
                    },
                    new Card
                    {
                        CardId = 10004,
                        Topic = "Software",
                        Title = "Change your background on Microsoft Teams during a meeting",
                        CreatedDate = new DateTime(2021, 12, 14, 13, 00, 00),
                        Step1 = "In the toolbar, click the ellipsis (three dots) to bring up a “More actions” menu",
                        Step2 = "Select “Show background effects” to bring up a sidebar menu on the right of your screen",
                        Step3 = "Choose a background from the sidebar menu",
                        Step4 = "You will be given the option to blur your background or use a custom image",
                        Step5 = "Choose a background, preview it if desired, then click “Apply and turn on video”",
                        UserId = 2
                    },
                    new Card
                    {
                        CardId = 10005,
                        Topic = "Software",
                        Title = "Create a chart in Microsoft Excel",
                        CreatedDate = new DateTime(2021, 10, 14, 13, 00, 00),
                        Step1 = "Select the range A1:E8 (Range of Values)",
                        Step2 = "On the Insert tab, in the Charts group, click the Line symbol",
                        Step3 = "Click Line with Markers",
                        Step4 = "Enter a title by clicking on Chart Title (Optional)",
                        UserId = 3
                    });


            modelBuilder.Entity<User>().HasData(
                        new User { Id = 1, Fname = "Fred", Lname = "Smith", Email = "fsmith@mail.com"},
                        new User { Id = 2, Fname = "Jane", Lname = "Doe", Email = "jdoe@mail.com" },
                        new User { Id = 3, Fname = "Thomas", Lname = "Anderson", Email = "aanderson@mail.com" });

        }
    }
}
