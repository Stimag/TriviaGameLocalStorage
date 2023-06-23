namespace TriviaGame.Pages.Gameplay
{
    public static class TestData
    {
        public static TriviaQuestion[] GetTestQuestions()
        {
            var random = new Random();

            var triviaData = new[]
            {
                new TriviaQuestion
                {
                    Question = "test",
                    Choices = new[] { "test", "test", "test", "test" },
                    CorrectChoice = 1
                },
                new TriviaQuestion
                {
                    Question = "test?",
                    Choices = new[] { "test", "test", "test", "test" },
                    CorrectChoice = 3
                }

            };
            
            // Randomize choices for each question
            foreach (var question in triviaData)
            {
                // Shuffle choices
                for (int i = question.Choices.Length - 1; i > 0; i--)
                {
                    int j = random.Next(i + 1);
                    (question.Choices[j], question.Choices[i]) = (question.Choices[i], question.Choices[j]);

                    // Update the correct choice index if it is affected by shuffling
                    if (question.CorrectChoice == i)
                    {
                        question.CorrectChoice = j;
                    }
                    else if (question.CorrectChoice == j)
                    {
                        question.CorrectChoice = i;
                    }
                }
            }

            return triviaData;
        }
    }
}

