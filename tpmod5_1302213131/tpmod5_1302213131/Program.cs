// See https://aka.ms/new-console-template for more information
internal class Program
{
    public class HaloGeneric
    {
        public static void sapaUser<T>(T inputuser)
        {
            Console.WriteLine("Hallo user " + inputuser);
        }
    }
    public class DataGeneric<T>
    {
        private T NIM;
        public DataGeneric(T NIM)
        {
            this.NIM = NIM;
        }
        public void PrintData()
        {
            Console.WriteLine("NIM yang tersimpan adalah: " + NIM);
        }
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Masukkan Nama Anda: ");
        string namamu = Console.ReadLine();
        Console.WriteLine("Masukkan NIM Anda: ");
        string NIM = Console.ReadLine();
        HaloGeneric.sapaUser<string>(namamu);
        DataGeneric<string> nim = new DataGeneric<string>(NIM);
        nim.PrintData();
    }
}