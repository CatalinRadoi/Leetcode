using System.Runtime.InteropServices.ComTypes;

namespace Leetcode.Easy
{
    internal class Problem118
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var output =new List<IList<int>>(1) { new List<int> { 1 } };
            
            if (numRows >= 2)
            {
                output.Add(new List<int>{1,1});
            }

            if (numRows == 2)
            {
                return output;
            }


            for (var i = 2; i < numRows; i++)
            {
                var list = new List<int>();
                
                var length = output[^1].Count;
                if (length % 2 == 0)
                {
                    var halfLength =  output[^1].Count / 2;
                }
                else
                {
                  
                }

                
                



                for (var j = 0; j < halfLength; j++)
                {
                    if (list.Count == 0)
                    {
                        list.Add(1);
                    }
                    else
                    {
                        list.Add(output[^1][j-1] + list[^1]);
                    }
                }
                list.Add(1);
                output.Add(list);
            }

            return output;
        }
    }
}
