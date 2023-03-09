    List<string> grid = new List<string>();
    grid.Add("1112");
    grid.Add("1912");
    grid.Add("1892");
    grid.Add("1234");

   //System.Console.WriteLine(grid.ElementAt(0).ElementAt(3));

    cavityMap(grid);

        static List<string> cavityMap(List<string> grid)
    {
        List<string> result = grid;

        // ignore first and last row
        for(int line=1; line<grid.Count-1; line++)
        {
            // ignore first and last cell
            for(int cell=1; cell<grid.ElementAt(0).Length-1; cell++)
            {
                int a =  Convert.ToInt16(grid.ElementAt(line)[cell].ToString());
                System.Console.WriteLine(a);
            }
        }
        return result;
    }

// 1112
// 1912
// 1892
// 1234