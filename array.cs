using System;

namespace IntroVS
{
    public static class ProjUtil
    {
        public void Array()
        {
            var arr=new List<int>{91,4,5,7,8,9,43,23,1,1,43};
            int i,k=arr.Length;
            for (int i= 0; i<k; i++)
            {
             int j; 
             for (j = 0; j < i; j++) 
             {
                   if (arr[i] == arr[j]) 
                    break; 
                    if (i == j) 
                    Console.Write(arr[i] + " ");   
             }
            }
        }
    }
}
