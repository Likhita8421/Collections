using Collections;
Collections.Collections CD = new Collections.Collections();
Console.WriteLine("1 - Run List Demo\n2 - Run Stack Demo\n3 - Queue Demo\n4 - Run Dictionary");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        {
            CD.ListDemo();
            break;
        }
    case 2:
        {
            CD.StackDemo();
            break;
        }
    case 3:
        {
            CD.QueueDemo();
            break;
        }
    case 4:
        {
            CD.Dictionary();
            break;
        }
}