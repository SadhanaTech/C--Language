//In this program we will learn about the @ verbatime


namespace UseOfVerbatim
{
    class UseOfVerbatime
    {
        static void Main()
        {
            System.String path1="c:\turboc\newfolder";
            System.String path2="c:\\turboc\\newfolder";//<------Solution Of Above Problem
            System.String path3 = @"c:\turboc\newfolder";//<------Solution Of Above Problem
            System.Console.WriteLine("Path1 : "+path1);
            System.Console.WriteLine("Path2 : "+path2);
            System.Console.WriteLine("Path3 : "+path3);
        }
 
    }
}
