

class Switch2{

    public static void Main(string[] args){

        Console.WriteLine("Enter a number: ");
        int choice = Convert.ToInt32(Console.ReadLine());


        switch(choice){

            case 1:
                Console.WriteLine("student details added successfully");
                break;

            case 2:
                Console.WriteLine("student details deleted");
                break;

            case 3:
                Console.WriteLine("view details");
                break;

            case 4:
                Console.WriteLine("update student details");
                break;

            default:
                Console.WriteLine("invalid number");
                break;
        }
    }
}