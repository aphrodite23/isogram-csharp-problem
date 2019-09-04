using System;

namespace Isogram
{
    public class Class1
    {
        public static bool isIsogram(string str){
            bool iso=true;
            for(int i=0;i<str.Length;i++){
                if(str[i] == ' ' || str[i]=='-'){
                    continue;
                }
                for(int j=i+1;j<str.Length;j++)
                {
                   if(str[i]==str[j]) {
                       iso=false;
                       break;
                   }
                }
                if(iso==false){
                    break;
                }
            }
            return iso;
        }
        static void Main(){}
        }
    

}


