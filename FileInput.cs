namespace M1AssignmentB
{
    public class FileInput
    {
        private string _fileName; 
        private StreamReader _sr = null; 
        
        public FileInput(string fileName)
        {
            _fileName = fileName;
            try
            {
                if(File.Exists(fileName))
                {
                    _sr = new StreamReader(_fileName);
                } 
            }
            catch(Exception e)
            {
                _fileName = ""; 
                Console.WriteLine("File Open Error: " + fileName + " " + e);
            }
        }

        public void FileRead()
        {
            string line; 
            try{
                while(!_sr.EndOfStream)
                {
                    line = _sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e); 
            }
        }

        public String FileReadLine()
        {
            try
            {
                string line = _sr.ReadLine();
                return line;
            }
            catch(Exception e)
            {
                Console.WriteLine("File Write Error: " + _fileName + " " + e); 
                return null;
            }
        }

        public void FileClose()
        {
            if( _sr != null)
            {
                try{
                    _sr.Close(); 
                }
                catch(IOException e)
                {
                    Console.WriteLine(e.StackTrace); 
                }
            }
        }

    }
}