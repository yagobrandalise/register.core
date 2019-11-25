using Newtonsoft.Json;

namespace register.core
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public DateTime Birth { get; set; }
    }

    public class DateTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
    }
    
     public class Student 
    {
        public Subject[] Classes { get; set; }
        public string[] ParentsId { get; set; }
        public int Registration { get; set; }
        public Subject[] History { get; set; }
    }

    public class Subject
    {
        public string Id { get; set; }
        public Student[] Students { get; set; }
        public string Professor { get; set; }
        public DateTime Schedule { get; set; }
        public int ClassId { get; set; }
        public string Tasks { get; set; }
        public string Local { get; set; }
        public float Value { get; set; }
    }

    public class Professor
    {
        public Subject[] Subjects { get; set; }
    }

    public class Parents
    {
        public string SonId { get; set; }
    }
}
