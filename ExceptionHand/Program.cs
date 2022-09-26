namespace ExceptionHand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
           FileStream fs= new FileStream("C:\\Users\\anand.kumar\\OneDrive - Entain Group\\Documents\\DA_Assignment\\test.txt", FileMode.OpenOrCreate);
            //fs.WriteByte(68);

            StreamWriter sw= new StreamWriter(fs);
            sw.WriteLine("Hello shivam how are u?");
            sw.Close();
            /*sr.WriteLine();
            while ()
            {

            }*/
            fs.Close();
        }
    }
}