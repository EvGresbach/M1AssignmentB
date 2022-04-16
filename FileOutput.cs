namespace M1AssignmentB
{
    public class FileOutput
    {
        private string _fileName; 
        private StreamWriter _sw = null; 

        public FileOutput(string fileName)
        {
            _fileName = fileName; 
            try
            {
                _sw = new StreamWriter(_fileName); 
            }
            catch(Exception e)
            {
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileWrite(string line)
        {
            try{
                _sw.WriteLine(line); 
            }
            catch(Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e);
            }
        }

        public void FileClose()
        {
            if( _sw != null)
            {
                try
                {
                    _sw.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}