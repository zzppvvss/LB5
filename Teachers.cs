namespace LB5
{
  internal class Teachers
  {
    public string Name { get; set; }
    public string Subjects { get; set; }
    public bool Lecture { get; set; }

    public Teachers(string name, string subjects, bool isStudying)
    {
      Name = name;
      Subjects = subjects;
      Lecture = isStudying;
    }
  }
}
