using System.ComponentModel;
using System.Text.Json;

namespace LB5
{
    public partial class FORMA : Form
    {
        Random Randomer = new Random();

        List<string> Subjects = new List<string> {
         "Математика",
         "Фізика",
         "Хімія",
         "Біологія",
         "Інформатика",
         "Історія",
         "Англійська мова",
         "Економіка",
         "Психологія",
         "Соціологія"
      };

        BindingList<Student> BindingListStudents = new BindingList<Student>();
        BindingList<Teachers> BindingListTeachers = new BindingList<Teachers>();

        List<string> events = new List<string>();

        public FORMA()
        {
            InitializeComponent();
        }

        // Log events
        private void LogStans(string value)
        {
            string fileName = "C:/Users/ripni/Desktop/lb5/test.json";

            events.Add(value);

            string json = JsonSerializer.Serialize(events);
            File.WriteAllText(fileName, json);
        }
        //загрузка UI
        private void FAORMALoading(object sender, EventArgs e)
        {
            List<Student> Students = new List<Student>();
            List<Teachers> Teachers = new List<Teachers>();

            Random rand = new Random();
            string[] firstNames = { "John", "Mary", "Alice", "Bob", "Samantha", "Oliver", "Emily", "William", "Lucy", "Michael" };
            string[] lastNames = { "Smith", "Johnson", "Lee", "Davis", "Wilson", "Anderson", "Thomas", "Jackson", "Garcia", "Brown" };

            for (int i = 0; i < 10; i++)
            {
                string firstName = firstNames[rand.Next(firstNames.Length)];
                string lastName = lastNames[rand.Next(lastNames.Length)];
                string name = firstName + " " + lastName;
                string subjects = string.Join(", ", RandSubj(3));
                bool isStudying = Randomer.Next(0, 2) == 1;

                Student student = new Student(name, subjects, isStudying);
                Students.Add(student);
            }

            BindingListStudents = new BindingList<Student>(Students);
            studentsGrid.DataSource = BindingListStudents;
            studentsGrid.Columns[0].Width = 60;
            studentsGrid.Columns[2].Width = 60;

            string[] names = { "John", "Jane", "Michael", "Elizabeth", "David", "Sarah", "Daniel", "Emily", "Christopher", "Olivia" };

            string[] surnames = { "Smith", "Johnson", "Williams", "Brown", "Jones", "Miller", "Davis", "Garcia", "Wilson", "Martinez" };

            for (int i = 0; i < Subjects.Count; i++)
            {
                string name = names[Randomer.Next(0, names.Length)];
                string surname = surnames[Randomer.Next(0, surnames.Length)];
                string subjects = Subjects[i];
                bool isStudying = Randomer.Next(0, 2) == 1;

                string teacherName =   $"{name} {surname}";

                Teachers teacher = new Teachers(teacherName, subjects, isStudying);
                Teachers.Add(teacher);
            }

            BindingListTeachers = new BindingList<Teachers>(Teachers);
            teachersGrid.DataSource = BindingListTeachers;
            teachersGrid.Columns[0].Width = 60;
            teachersGrid.Columns[2].Width = 60;

            LogStans("Start");
        }

        //Случайные доп предметы
        public static string RandomSubjectList()
        {
            List<string> subjects = new List<string>() {
            "Основи програмування",
            "Алгоритми та структури даних",
            "Теорія баз даних",
            "Операційні системи",
            "Мережеві технології",
            "Програмування на C#",
            "Web-програмування",
            "Інженерія програмного забезпечення",
            "Комп'ютерна графіка та обробка зображень",
            "Штучний інтелект та машинне навчання"
         };
            Random random = new Random();
            int index = random.Next(subjects.Count);

            return subjects[index];
        }

        private List<string> RandSubj(int count)
        {
            List<string> randomSubjects = new List<string>(Subjects);
            for (int i = 0; i < randomSubjects.Count; i++)
            {
                int j = Randomer.Next(i, randomSubjects.Count);
                string temp = randomSubjects[i];
                randomSubjects[i] = randomSubjects[j];
                randomSubjects[j] = temp;
            }

            randomSubjects = randomSubjects.Take(count).ToList();

            return randomSubjects;
        }
        
        // Фунции что меняют
        private void ChangeSubjects(List<string> NewSubjects)
        {
            Invoke(new Action(() => {
                Subjects = NewSubjects;
            }));
        }
        private void ChangeText(string text)
        {
            Invoke(new Action(() => {
                modeText.Text = text;
                LogStans(text);
            }));
        }
        private void ChangeTeachers(BindingList<Teachers> NewTeachers)
        {
            Invoke(new Action(() => {
                BindingListTeachers.Clear();
                foreach (Teachers t in NewTeachers)
                {
                    BindingListTeachers.Add(t);
                }
            }));
        }
        private void ChangeStudents(BindingList<Student> NewStudents)
        {
            Invoke(new Action(() => {
                BindingListStudents.Clear();
                foreach (Student s in NewStudents)
                {
                    BindingListStudents.Add(s);
                }
            }));
        }


        // ВСТУПНА КОМПАНІЯ
        private void vstupOnClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(VstupStatus);
            thread.Start();
        }

        private void VstupStatus()
        {
            Thread.Sleep(3000);

            BindingList<Student> Temp = new BindingList<Student>(BindingListStudents.ToList());

            // Удалить случайное количество студентов из списка.
            for (int i = 0; i < Randomer.Next(Temp.Count); i++)
            {
                int indexToDelete = Randomer.Next(Temp.Count);
                LogStans("Student " + Temp[indexToDelete].Name + " delete");
                Temp.RemoveAt(indexToDelete);
            }

            // Добавить новых студентов в список.
            for (int i = 0; i < Randomer.Next(3, 6); i++)
            {
                string name = "Student" + Guid.NewGuid().ToString();
                List<string> subs = RandSubj(4);
                string subjects = string.Join(", ", subs);
                // Случайным образом определить, учится ли студент в данный момент.
                bool isStudying = Randomer.Next(0, 2) == 1;
                Student student = new Student(name, subjects, isStudying);

                Temp.Add(student);

                LogStans("New Student: " + name);
            }

            ChangeStudents(Temp);

            ChangeText("ВСТУПНА КАМПАНІЯ");
        }

        //  ПРОЦЕСС НАВЧАННЯ

        private void standartStudyOnClick(object sender, EventArgs e)
        {
            Thread thread = new Thread(SemestrStatus);
            thread.Start();
        }

        // Все учителя работают
        private void SemestrStatus()
        {
            Thread.Sleep(3000);

            BindingList<Teachers> TecherTemp = new BindingList<Teachers>(BindingListTeachers.ToList());

            foreach (Teachers t in TecherTemp)
            {
                t.Lecture = true;
                LogStans("Teachers \"" + t.Name + "\" works!");
            }
            ChangeTeachers(TecherTemp);

            ChangeText("ПРОВЕДЕННЯ ЗАНЯТЬ");
        }

        // ВІДПУСТКИ
        private void vidpustkaOnclick(object sender, EventArgs e)
        {
            Thread thread = new Thread(VidpustkaStatus);
            thread.Start();
        }

        private void VidpustkaStatus()
        {
            Thread.Sleep(3000);

            BindingList<Teachers> TeacherTemp = new BindingList<Teachers>(BindingListTeachers.ToList());
            BindingList<Student> TempStudents = new BindingList<Student>(BindingListStudents.ToList());
            List<string> NewSubjects = new List<string>(Subjects);

            for (int i = 0; i < Randomer.Next(TeacherTemp.Count); i++)
            {
                int changedindexes = Randomer.Next(TeacherTemp.Count);
                TeacherTemp[changedindexes].Lecture = false;
                LogStans("Teachers \"" + TeacherTemp[changedindexes].Name + "\" has a job!");
            }

            foreach (Student s in TempStudents)
            {
                s.Learning = false;
            }
            LogStans("Vidpustka");

            // удаление случайных предмктов
            for (int i = 0; i < Randomer.Next(NewSubjects.Count); i++)
            {

                int changedindexes = Randomer.Next(NewSubjects.Count);
                string deletedsubj = NewSubjects[changedindexes];

                foreach (Teachers t in TeacherTemp)
                {
                    List<string> ts = t.Subjects.Split(',').Select(s => s.Trim()).ToList();

                    if (ts.Count > 1)
                    {
                        ts.RemoveAll(x => x == deletedsubj);
                        t.Subjects = string.Join(",", ts);
                    }
                }

                foreach (Student s in TempStudents)
                {
                    List<string> ss = s.Subjects.Split(',').Select(s => s.Trim()).ToList();
                    if (ss.Count > 1)
                    {
                        ss.RemoveAll(x => x == deletedsubj);
                        s.Subjects = string.Join(",", ss);
                    }
                }

                LogStans("Subject \"" + deletedsubj + "\" deleted");

                NewSubjects.RemoveAt(changedindexes);
            }

            for (int i = 0; i < Randomer.Next(NewSubjects.Count); i++)
            {
                string newname = RandomSubjectList();

                // Добавляем новый предмет к случайно выбранным учителям
                for (int j = 0; j < Randomer.Next(TeacherTemp.Count); j++)
                {
                    int TIndexToChange = Randomer.Next(TeacherTemp.Count);

                    List<string> ts = TeacherTemp[TIndexToChange].Subjects.Split(',').Select(s => s.Trim()).ToList();

                    // Если такого предмета еще нет у учителя, добавляем его
                    if (!ts.Contains(newname))
                    {
                        ts.Add(newname);
                        TeacherTemp[TIndexToChange].Subjects = string.Join(",", ts);
                    }
                }

                // Добавляем новый предмет к случайно выбранным ученикам
                for (int c = 0; c < Randomer.Next(TempStudents.Count); c++)
                {
                    int SIndexToChange = Randomer.Next(TempStudents.Count);

                    List<string> ss = TempStudents[SIndexToChange].Subjects.Split(',').Select(s => s.Trim()).ToList();

                    // Если такого предмета еще нет у ученика, добавляем его
                    if (!ss.Contains(newname))
                    {
                        ss.Add(newname);
                        TempStudents[SIndexToChange].Subjects = string.Join(",", ss);
                    }
                }

                NewSubjects.Add(newname);

                LogStans("Subject \"" + newname + "\" add");
            }

            ChangeTeachers(TeacherTemp);
            ChangeStudents(TempStudents);
            ChangeSubjects(NewSubjects);

            ChangeText("ВІДПУСТКА");
        }

        private void modeText_Click(object sender, EventArgs e)
        {

        }
    }
}