//using System;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ООП_лаба_исключения
//{
//     class ConvertString1
//    {
//       private string value;

//        public int ValueInt
//        {
//              get 
//              {
//                bool flag = true;
//                for (int i=0;i<value.Length;i++)
//                {
//                    if (!(value[i] <= 9 && value[i] >= 0))
//                    {
//                        flag = false;
//                        break;
//                    }                  
//                }
//                if (flag)
//                    return Convert.ToInt32(value);
//                else
//                    throw new CustomException();
//              }
//        }


//    }
//    class ConvertString: Exception 
//    {
//        public string Value { get; set; }
        
//        public CustomException():base() { }
//        public CustomException(string msg) : base(msg)
//        { 
//        }
//        public CustomException(string msg, Exception inner) : base(msg,inner) 
//        {
//        }
//        public CustomException(string msg,string value): base(msg)
//        {
//            Value = value;
//        }
//    }    
//}
