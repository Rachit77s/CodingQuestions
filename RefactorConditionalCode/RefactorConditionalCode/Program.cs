using System;
using System.Linq;
using System.Xml.Linq;

namespace RefactorConditionalCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region Problem Statement
        public void FlattenXml(XElement xml, string id = null)
        {
            var elements = xml.Elements().ToList();
            foreach (var element in elements)
            {
                //if (element.Name == "name1")
                //{
                //    Func1();
                //}
                //if (element.Name == "name2")
                //{
                //    Func2();
                //}
                //if (element.Name == "name3")
                //{
                //    DoSomethingElse();
                //    FlattenXml(content, tempId);
                //    Func3();
                //}
                //else
                //{
                //    DoSomethingCompletelyDifferent();
                //    FlattenXml(element, id);
                //}
            }
            xml.Elements("name3").Remove();
        }

        #endregion
    }
}
