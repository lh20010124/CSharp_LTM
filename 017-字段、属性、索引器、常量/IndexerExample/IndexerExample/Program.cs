namespace IndexerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
    }
    class Student
    {
        private Dictionary<string, int> ScoreDictionary = new Dictionary<string, int>();

        public int? this[string subject]
        {
            get 
            {
                /* return the specified index here */
                if (this.ScoreDictionary.ContainsKey(subject))
                {
                    return this.ScoreDictionary[subject];
                }
                else
                {
                    return null;
                }
            }
            set 
            {
                /* set the specified index to value here */
                if (value.HasValue==false)
                {
                    throw new Exception("Score cannot be null.");
                }
                if (this.ScoreDictionary.ContainsKey(subject))
                {
                    this.ScoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.ScoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
}
