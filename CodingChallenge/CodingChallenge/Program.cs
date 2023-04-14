using CodingChallenge;

string[] data = GetTestData();

foreach (var item in data)
{
    Console.WriteLine($"{item} - {(Lib.HasMatchingBrackets(item) ? "true" : "false")}");
}

string[] GetTestData()
{
    var testData = new string[] {
        "<>",
        "><",
        "<<>",
        "",
        string.Empty,
        "<abc...xyz>",
        "<a<b<c>>d>e>f",
        "<h<e<y<s<o>u>l>s>i>s>t<e<r>>",
        "<<a>><<b>>",
        "abc",
        "<<<<<>>>>>",
        "<<>><>",
        "<<<><><>>",
        "><<>><",
        "n<<o>rm<a<n>>>"
    };
    return testData;
}






