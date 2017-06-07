using FinalProject.DomainData;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace FinalProject.Migrations
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FinalProjectContext(
                serviceProvider.GetRequiredService<DbContextOptions<FinalProjectContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any() || context.Categories.Any() || context.Users.Any())
                {
                    return;   // DB has been seeded
                }

                context.Users.AddRange(
                    new User
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActivated = true,
                        IsAdmin = true,
                        Email = "admin@geekmovie.com",
                        Password = "admin123",
                        Name = "Admin",
                        Phone = "087812345678"
                    },
                    new User
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActivated = true,
                        IsAdmin = true,
                        Email = "admin2@geekmovie.com",
                        Password = "admin123",
                        Name = "Admin 2",
                        Phone = "087812345678"
                    },
                    new User
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActivated = true,
                        IsAdmin = false,
                        Email = "user@geekmovie.com",
                        Password = "user123",
                        Name = "User",
                        Phone = "087812345678"
                    },
                    new User
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        IsActivated = true,
                        IsAdmin = false,
                        Email = "user2@geekmovie.com",
                        Password = "user123",
                        Name = "User 2",
                        Phone = "087812345678"
                    }
                );

                context.Categories.AddRange(
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Action"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Biography"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Family"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Horror"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Romance"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Thriller"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Fantasy"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Adventure"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Comedy"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Animation"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Drama"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "History"
                    },
                    new Category
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Name = "Musical"
                    }
                );

                context.SaveChanges();

                context.Movies.AddRange(
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Disney Moana",
                        Viewed = 0,
                        Released = new DateTime(2016, 11, 25),
                        Description = "An adventurous teenager sails out on a daring mission to save her people. During her journey, Moana meets the once-mighty demigod Maui, who guides her in her quest to become a master way-finder. Together they sail across the open ocean on an action-packed voyage, encountering enormous monsters and impossible odds. Along the way, Moana fulfills the ancient quest of her ancestors and discovers the one thing she always sought: her own identity.",
                        BackgroundUrl = "b1.jpg",
                        ThumbnailUrl = "c1.jpg",
                        Category = new Category { Id = 3 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Dirty Grandpa",
                        Viewed = 0,
                        Released = new DateTime(2016, 1, 21),
                        Description = "Uptight lawyer Jason Kelly (Zac Efron) is one week away from marrying his boss's controlling daughter, putting him on the fast track for a partnership at his firm. Tricked by his grandfather Dick (Robert De Niro), Jason finds himself driving the foulmouthed old man to Daytona Beach, Fla., for a wild spring break that includes frat parties, bar fights and an epic night of karaoke. While Jason worries about the upcoming wedding, Dick tries to show his grandson how to live life to the fullest.",
                        BackgroundUrl = "b2.jpg",
                        ThumbnailUrl = "c2.jpg",
                        Category = new Category { Id = 4 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Ride Along 2",
                        Viewed = 0,
                        Released = new DateTime(2016, 1, 6),
                        Description = "Rookie lawman Ben Barber (Kevin Hart) aspires to become a detective like James Payton (Ice Cube), his future brother-in-law. James reluctantly takes Ben to Miami to follow up on a lead that's connected to a drug ring. The case brings them to a homicide detective and a computer hacker who reveals evidence that implicates a respected businessman. It's now up to James and Ben to prove that charismatic executive Antonio Pope is actually a violent crime lord who rules southern Florida's drug trade.",
                        BackgroundUrl = "b3.jpg",
                        ThumbnailUrl = "c3.jpg",
                        Category = new Category { Id = 12 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Keanu",
                        Viewed = 0,
                        Released = new DateTime(2016, 4, 29),
                        Description = "Recently dumped by his girlfriend, slacker Rell (Jordan Peele) finds some happiness when a cute kitten winds up on his doorstep. After a heartless thief steals the cat, Rell recruits his cousin Clarence (Keegan-Michael Key) to help him retrieve it. They soon learn that a thug named Cheddar (Method Man) has the animal, and he'll only give it back if the two men agree to work for him. Armed with guns and a gangster attitude, it doesn't take long for the hapless duo to land in big trouble.",
                        BackgroundUrl = "b5.jpg",
                        ThumbnailUrl = "c5.jpg",
                        Category = new Category { Id = 12 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Ice Age : Collision Course",
                        Viewed = 0,
                        Released = new DateTime(2016, 7, 29),
                        Description = "Manny the mammoth starts to worry when his daughter Peaches announces her engagement. Still unlucky in love, Sid the sloth volunteers to plan the couple's wedding. To Manny's dismay, nothing can stop the upcoming nuptials, except maybe the end of the world. When Scrat accidentally launches himself into outer space, he sets off a chain reaction that sends an asteroid hurtling toward Earth. Now, the entire herd must leave home to explore new lands and save itself from Scrat's cosmic blunder.",
                        BackgroundUrl = "b6.jpg",
                        ThumbnailUrl = "c6.jpg",
                        Category = new Category { Id = 6 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Mike and Dave Need Wedding Dates",
                        Viewed = 0,
                        Released = new DateTime(2016, 6, 30),
                        Description = "Mike and Dave Stangle are young, adventurous, fun-loving brothers who tend to get out of control at family gatherings. When their sister Jeanie reveals her Hawaiian wedding plans, the rest of the clan insists that they both bring respectable dates. After placing an ad on Craigslist, the siblings decide to pick Tatiana and Alice, two charming and seemingly normal women. Once they arrive on the island, however, Mike and Dave realize that their companions are ready to get wild and party hard.",
                        BackgroundUrl = "b7.jpg",
                        ThumbnailUrl = "c7.jpg",
                        Category = new Category { Id = 1 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Bad Moms",
                        Viewed = 0,
                        Released = new DateTime(2016, 9, 14),
                        Description = "Amy (Mila Kunis) has a great husband, overachieving children, beautiful home and successful career. Unfortunately, she's also overworked, exhausted and ready to snap. Fed up, she joins forces with two other stressed-out mothers (Kristen Bell, Kathryn Hahn) to get away from daily life and conventional responsibilities. As the gals go wild with their newfound freedom, they set themselves up for the ultimate showdown with PTA queen bee Gwendolyn and her clique of seemingly perfect moms.",
                        BackgroundUrl = "b8.jpg",
                        ThumbnailUrl = "c8.jpg",
                        Category = new Category { Id = 4 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Barbershop: The Next Cut",
                        Viewed = 0,
                        Released = new DateTime(2016, 4, 15),
                        Description = "AmyTo survive harsh economic times, Calvin and Angie have merged the barbershop and beauty salon into one business. The days of male bonding are gone as Eddie and the crew must now contend with sassy female co-workers and spirited clientele. As the battle of the sexes rages on, a different kind of conflict has taken over Chicago. Crime and gangs are on the rise, leaving Calvin worried about the fate of his son. Together, the friends come up with a bold plan to take back their beloved neighborhood.",
                        BackgroundUrl = "b9.jpg",
                        ThumbnailUrl = "c9.jpg",
                        Category = new Category { Id = 2 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Nine Lives",
                        Viewed = 0,
                        Released = new DateTime(2016, 11, 25),
                        Description = "Tom Brand (Kevin Spacey) is a billionaire whose workaholic lifestyle takes him away from his loving wife Lara and adorable daughter Rebecca. Needing a present for Rebecca's 11th birthday, Brand buys a seemingly harmless cat from a mysterious pet store. Suddenly, a bizarre turn of events traps poor Tom inside the animal's body. The owner of the business tells him that he has one week to reconnect with his family, or live out the rest of his days as a cute and furry feline named Mr. Fuzzypants.",
                        BackgroundUrl = "b10.jpg",
                        ThumbnailUrl = "c10.jpg",
                        Category = new Category { Id = 6 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Billy Lynn's Long Halftime Walk",
                        Viewed = 0,
                        Released = new DateTime(2016, 11, 9),
                        Description = "Nineteen-year-old private Billy Lynn (Joe Alwyn), along with his fellow soldiers in Bravo Squad, becomes a hero after a harrowing Iraq battle and is brought home temporarily for a victory tour. Through flashbacks, culminating at the spectacular halftime show of the Thanksgiving Day football game, what really happened to the squad is revealed, contrasting the realities of the war with America's perceptions. Based on the novel by Ben Fountain.",
                        BackgroundUrl = "b11.jpg",
                        ThumbnailUrl = "c11.jpg",
                        Category = new Category { Id = 8 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "War on Everyone",
                        Viewed = 0,
                        Released = new DateTime(2016, 11, 3),
                        Description = "Two corrupt cops, who make money blackmailing criminals, come up against one who may be far more dangerous than both of them.",
                        BackgroundUrl = "b12.jpg",
                        ThumbnailUrl = "c12.jpg",
                        Category = new Category { Id = 12 }
                    },
                    new Movie
                    {
                        CreatedDate = DateTime.Now,
                        ModifiedDate = DateTime.Now,
                        IsDeleted = false,
                        Title = "Before I Wake",
                        Viewed = 0,
                        Released = new DateTime(2016, 11, 12),
                        Description = "Foster parents Mark and Jessie welcome 8-year-old Cody into their home. The boy tells Jessie that he's terrified to fall asleep, but she assumes it's just a natural fear for any young child. The couple become startled when their dead biological son suddenly appears in their living room. To their surprise, Cody's dreams can magically become real but so can his nightmares. Mark and Jessie must now uncover the truth behind Cody's mysterious ability before his imagination harms them all.",
                        BackgroundUrl = "b13.jpg",
                        ThumbnailUrl = "c13.jpg",
                        Category = new Category { Id = 2 }
                    }
                );
                
                context.SaveChanges();
            }
        }
    }
}
