namespace CodingExercise.Tests
{
    [TestClass]
    public class SubtextTests
    {
        const string text = "How much wood would a Woodchuck chuck, if a Woodchuck could chuck wood?";

        [TestMethod]
        [DataRow("How", new int[] { 1 })]
        [DataRow("?", new int[] { 71 })]
        public void Subtexts_Positions_Should_Return_Correct_Position(string subtextSearchTerm, int[] resultPositions)
        {
            Subtext subtext = new Subtext();

            var result = subtext.Positions(text, subtextSearchTerm);

            CollectionAssert.AreEqual(resultPositions, result);
        }

        [TestMethod]
        [DataRow("wooden", new int[] { })]
        [DataRow("x", new int[] { })]
        public void Subtexts_Positions_Should_Return_Empty_If_No_Matches(string subtextSearchTerm, int[] resultPositions)
        {
            Subtext subtext = new Subtext();

            var result = subtext.Positions(text, subtextSearchTerm);

            CollectionAssert.AreEqual(resultPositions, result);
        }

        [TestMethod]
        [DataRow(text + "Extra Text", new int[] { })]
        [DataRow(text + "E", new int[] { })]
        public void Subtexts_Positions_Should_Return_Empty_When_Subtext_Is_longer_Than_text(string subtextSearchTerm, int[] resultPositions)
        {
            Subtext subtext = new Subtext();

            var result = subtext.Positions(text, subtextSearchTerm);

            CollectionAssert.AreEqual(resultPositions, result);
        }


        [TestMethod]
        [DataRow("would", new int[] { 15 })]
        [DataRow("oo", new int[] { 11, 24, 46, 68 })]
        public void Subtexts_Positions_Should_Return_Correct_Positions(string subtextSearchTerm, int[] resultPositions)
        {
            Subtext subtext = new Subtext();

            var result = subtext.Positions(text, subtextSearchTerm);

            CollectionAssert.AreEqual(resultPositions, result);
        }

        [TestMethod]
        [DataRow("wood", new int[] { 10, 23, 45, 67 })]
        [DataRow("Wood", new int[] { 10, 23, 45, 67 })]
        [DataRow("oo", new int[] { 11, 24, 46, 68 })]
        [DataRow("oO", new int[] { 11, 24, 46, 68 })]
        public void Subtexts_Positions_Should_Return_Correct_Positions_Case_Insenstive(string subtextSearchTerm, int[] resultPositions)
        {
            Subtext subtext = new Subtext();

            var result = subtext.Positions(text, subtextSearchTerm);

            CollectionAssert.AreEqual(resultPositions, result);
        }
    }
}