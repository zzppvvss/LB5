namespace LB5
{
  internal class Student
  {
    public string Name { get; set; }
    public string Subjects { get; set; }
    public bool Learning { get; set; }

    public Student(string name, string subjects, bool isStudying)
    {
      Name = name;
      Subjects = subjects;
      Learning = isStudying;
    }
  }
}
