using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LinkedList
{
    public class UserAction
    {
        public CustomeLinkedList<string> customerLinkedList = null;
        public static UserAction _useraction;
        public UserAction() { }
        public static UserAction GetUserAction()
        {
            if(_useraction == null)
            {
                _useraction = new UserAction(); 
            }
            return _useraction;
        }
        
        public enum Options
        {
            Create = 1,
            Exit = 2
        }
        public void Perform()
        {
            Options option;
            do
            {
                Enum.TryParse(ReadLine(), out option);
                switch (option)
                {
                    case Options.Create:
                        {
                            OutputEncoding = Encoding.UTF8;
                            customerLinkedList = customerLinkedList ?? new CustomeLinkedList<string>();
                            customerLinkedList.Add("Vũ");
                            customerLinkedList.Add(" Phạm");
                            customerLinkedList.Add(" Tiến");
                            customerLinkedList.Add(" Dũng");
                            customerLinkedList.Traverse(c => Write($"{c} "));
                            var n = customerLinkedList.Insert("my", " from");
                            customerLinkedList.Insert("super ", n);
                            WriteLine();
                            customerLinkedList.Traverse(c => Write($"{c} "));
                            ReadLine();
                            break;
                        }
                    case Options.Exit:
                        {
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (option != Options.Exit);
        }
    }
}
