namespace OOP_Principles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("These are the OOP basics. This example is about a person, an employee and a manager. \nCheck the code for further examples");               
            //This is an object creation
            //When a class is instanciated, we have an object
            //"Person" is the class, "person_object" the object
            Person person_object;

            //Now let큦 initialize the object
            person_object = new Person("Jhon", 21, 180, 90, "Male");
            //Now let큦 generate the secret number
            person_object.special_secret_number = person_object.Generate_Special_Secret_Number(21);
            MessageBox.Show("First, lets create a person and check this person큦 info (abstraction):\n" + person_object.Get_person_properties());
            MessageBox.Show("The 'person' class generates a secret number. Check it!! \nNo one knows how to calculate this number, except the 'person' class (encapsulation): " + person_object.special_secret_number.ToString());

            //Lets create an employee
            Employee employee_object = new Employee(12, new DateTime(2022, 12, 31), 1200, "Kevin", 23, 185, 94, "male");
            MessageBox.Show("Now, let큦 create an 'employee' class and check this employee큦 info (the 'employee' is inheriting from 'Person'): \n" + employee_object.get_Employee_properties());

            Manager manager = new Manager("financial", 12, new DateTime(2022, 12, 31), 1200, "Lisa", 25, 165, 75, "female");
            MessageBox.Show("Now, let큦 create a 'manager' class; check this manager큦 info (the 'Manager' is inheriting from 'Employee')(Inheritance): \n"+ manager.get_info());

            MessageBox.Show($"The last step: The 'manager' and the 'employee' classes implement the same method, but each in different ways. Let큦 check the function to calculate the pay rise (Polymorphism). \nManager: {manager.increase_salary()} U$S \nEmployee: {employee_object.increase_salary()} U$S");

            MessageBox.Show("Thanks for participate of this basics demo!");

            Application.Exit();


        }
    }
}
