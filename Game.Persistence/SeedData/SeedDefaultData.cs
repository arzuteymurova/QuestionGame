using Game.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Game.Persistence.SeedData
{
    public static class SeedDefaultData
    {
        private static List<Category> categories = new List<Category>
        {
            new Category
            {
                Id=1,
                Name="Math",

            },

             new Category
            {
                Id=2,
                Name="History",

            },
              new Category
            {
                Id=3,
                Name="Geograpy",

            }
             ,
               new Category
            {
                Id=4,
                Name="litrature",

            }
        };
        private static List<DifficultyLevel> difficultyLevels = new List<DifficultyLevel>
        {
            new DifficultyLevel
            {
                Id=1,
                Difficulty ="Easy",
               // CategoryId=1
            },
            new DifficultyLevel
            {
                Id=2,
                Difficulty ="Medium",
               // CategoryId=1
            },
            new DifficultyLevel
            {
                Id=3,
                Difficulty ="Hard",
               //  CategoryId=1
            }
        };
        private static List<Question> questions = new List<Question>
        {
            new Question
            {
                Id=1,
                Content = "2*2",
                DifficultLevelId=1,
                CategoryId=1

            },
            new Question
            {
                Id=2,
                Content = "2*9",
                DifficultLevelId =1,
                CategoryId=1

            },
             new Question
            {
                Id=3,
                Content = "7*8",
                DifficultLevelId =1,
                CategoryId=1
            },
             new Question
             {
                 Id=4,
                 Content ="sin^2a+cos^2a = ?",
                 DifficultLevelId=2,
                CategoryId=1

             },
              new Question
             {
                 Id=5,
                 Content ="888 + 88 + 8 + 8 + 8  ?",
                 DifficultLevelId=2,
                CategoryId=1

             },
               new Question
             {
                 Id=6,
                 Content ="-15+ (-5x) =0",
                 DifficultLevelId=2,
                CategoryId=1

             },
             new Question
             {
                 Id=7,
                 Content ="1.92÷3",
                 DifficultLevelId=2,
                CategoryId=1

             },
             new Question
             {
                 Id=8,
                 Content ="121 Divided by 11 is ",
                 DifficultLevelId=3,
                CategoryId=1

             },
             new Question
             {
                 Id=9,
                 Content =" 60 Times of 8 Equals to ",
                 DifficultLevelId=3,
                CategoryId=1

             },
             new Question
             {
                 Id=10,
                 Content ="Find the Missing Term in Multiples 6, 12, 18, 24, _, 36, 42, _ 54, 60.",
                 DifficultLevelId=3,
                 CategoryId=1

             },
             new Question
             {
                 Id=11,
                 Content =" What is the Next Prime Number after 7 ?",
                 DifficultLevelId=3,
                CategoryId=1

             },
             new Question
             {
                 Id=12,
                 Content ="The Product of 131 × 0 × 300 × 4",
                 DifficultLevelId=3,
                CategoryId=1

             },




        };
        private static List<Answer> answers = new List<Answer>
        {
            new Answer
            {
              Id =1,
              Value ="1",
              IsTrue=IsTrue.False,
              QuestionId =1

            },
            new Answer
            {
              Id =2,
              Value ="2",
              IsTrue=IsTrue.False,
              QuestionId =1

            },
            new Answer
            {
              Id =3,
              Value ="3",
              IsTrue=IsTrue.False,
              QuestionId =1

            },
            new Answer
            {
              Id =4,
              Value ="4",
              IsTrue=IsTrue.True,
              QuestionId =1

            },
            new Answer
            {
              Id =5,
              Value ="1",
              IsTrue=IsTrue.False,
              QuestionId =2

            },
            new Answer
            {
              Id =6,
              Value ="992",
              IsTrue=IsTrue.False,
              QuestionId =2

            },
            new Answer
            {
              Id =7,
              Value ="123",
              IsTrue=IsTrue.False,
              QuestionId =2

            },
            new Answer
            {
              Id =8,
              Value ="18",
              IsTrue=IsTrue.True,
              QuestionId =2

            },
             new Answer
            {
              Id =9,
              Value ="18",
              IsTrue=IsTrue.False,
              QuestionId =3

            },
            new Answer
            {
              Id =10,
              Value ="121",
              IsTrue=IsTrue.False,
              QuestionId =3

            },
              new Answer
            {
              Id =11,
              Value ="56",
              IsTrue=IsTrue.True,
              QuestionId =3

            },
            new Answer
            {
              Id =12,
              Value ="5kmk",
              IsTrue=IsTrue.False,
              QuestionId =3

            },
            new Answer
            {
                Id =13,
                Value ="1",
                IsTrue=IsTrue.True,
                QuestionId =4
            },
             new Answer
            {
                Id =14,
                Value ="2",
                IsTrue=IsTrue.False,
                QuestionId =4
            },
              new Answer
            {
                Id =15,
                Value ="3",
                IsTrue=IsTrue.False,
                QuestionId =4
            },
               new Answer
            {
                Id =16,
                Value ="100",
                IsTrue=IsTrue.False,
                QuestionId =4
            },
            new Answer
            {
                Id =17,
                Value ="1000",
                IsTrue=IsTrue.True,
                QuestionId =5
            },
            new Answer
            {
                Id =18,
                Value ="1001",
                IsTrue=IsTrue.False,
                QuestionId =5
            },
            new Answer
            {
                Id =19,
                Value ="1002",
                IsTrue=IsTrue.False,
                QuestionId =5
            },
            new Answer
            {
                Id =20,
                Value ="1008",
                IsTrue=IsTrue.False,
                QuestionId =5
            },
            new Answer
            {
                Id =21,
                Value ="-3",
                IsTrue=IsTrue.True,
                QuestionId =6
            },
             new Answer
            {
                Id =22,
                Value ="-5",
                IsTrue=IsTrue.False,
                QuestionId =6
            },
              new Answer
            {
                Id =23,
                Value ="-32",
                IsTrue=IsTrue.False,
                QuestionId =6
            },
               new Answer
            {
                Id =24,
                Value ="-39",
                IsTrue=IsTrue.False,
                QuestionId =6
            },
            new Answer
            {
                Id =25,
                Value ="-0.54",
                IsTrue=IsTrue.False,
                QuestionId =7
            },
             new Answer
            {
                Id =26,
                Value ="-64",
                IsTrue=IsTrue.True,
                QuestionId =7
            },
              new Answer
            {
                Id =27,
                Value ="-0.44",
                IsTrue=IsTrue.False,
                QuestionId =7
            },
               new Answer
            {
                Id =28,
                Value ="-0.541",
                IsTrue=IsTrue.False,
                QuestionId =7
            },
            new Answer
            {
                Id =29,
                Value ="11",
                IsTrue=IsTrue.True,
                QuestionId =8
            },
              new Answer
            {
                Id =30,
                Value ="10",
                IsTrue=IsTrue.False,
                QuestionId =8
            },
             new Answer
            {
                Id =31,
                Value ="19",
                IsTrue=IsTrue.False,
                QuestionId =8
            },
            new Answer
            {
                Id =32,
                Value ="18",
                IsTrue=IsTrue.False,
                QuestionId =8
            },
             new Answer
            {
                Id =33,
                Value ="480",
                IsTrue=IsTrue.True,
                QuestionId =9
            },
              new Answer
            {
                Id =34,
                Value ="300",
                IsTrue=IsTrue.False,
                QuestionId =9
            },
            new Answer
            {
                Id =35,
                Value ="250",
                IsTrue=IsTrue.False,
                QuestionId =9
            },
            new Answer
            {
                Id =36,
                Value ="400",
                IsTrue=IsTrue.False,
                QuestionId =9
            },
             new Answer
            {
                Id =37,
                Value ="32, 45",
                IsTrue=IsTrue.False,
                QuestionId =10
            },
              new Answer
            {
                Id =38,
                Value ="30, 48",
                IsTrue=IsTrue.True,
                QuestionId =10
            },
             new Answer
            {
                Id =39,
                Value ="24, 40",
                IsTrue=IsTrue.False,
                QuestionId =10
            },
              new Answer
            {
                Id =40,
                Value ="25, 49",
                IsTrue=IsTrue.False,
                QuestionId =10
            },
            new Answer
            {
                Id =41,
                Value ="13",
                IsTrue=IsTrue.False,
                QuestionId =11
            },
             new Answer
            {
                Id =42,
                Value ="12",
                IsTrue=IsTrue.False,
                QuestionId =11
            },
              new Answer
            {
                Id =43,
                Value ="14",
                IsTrue=IsTrue.False,
                QuestionId =11
            },
               new Answer
            {
                Id =44,
                Value ="11",
                IsTrue=IsTrue.True,
                QuestionId =11
            },
                new Answer
            {
                Id =45,
                Value ="11",
                IsTrue=IsTrue.False,
                QuestionId =12
            },
             new Answer
            {
                Id =46,
                Value ="0",
                IsTrue=IsTrue.True,
                QuestionId =12
            },
            new Answer
            {
                Id =47,
                Value ="46",
                IsTrue=IsTrue.False,
                QuestionId =12
            },
             new Answer
            {
                Id =48,
                Value ="45",
                IsTrue=IsTrue.False,
                QuestionId =12
            },

        };
        private static List<Gamer> gamers = new List<Domain.Entities.Gamer>()
        {
            new() { Id = 1,UserName="Arzu" },
            new() { Id = 2,UserName="Sadiq"},
        };

        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<DifficultyLevel>().HasData(difficultyLevels);
            modelBuilder.Entity<Question>().HasData(questions);
            modelBuilder.Entity<Answer>().HasData(answers);
            modelBuilder.Entity<Gamer>().HasData(gamers);


        }
    }
}
