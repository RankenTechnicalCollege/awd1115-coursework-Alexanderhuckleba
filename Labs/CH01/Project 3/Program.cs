int rows, cols;
bool isValid;

do
{
    Console.WriteLine("How many rows should the table have?");
    isValid = int.TryParse(Console.ReadLine(), out rows);
}while(!isValid);


do
{
    Console.WriteLine("How many columns should the table have?");
    isValid = int.TryParse((string)Console.ReadLine(), out cols);
}while(!isValid);

for (int i = 0; i < rows; i++)
{
    if(rows == 0)
    {
        for (int col = 1; col <= cols; col++)
        {
            Console.Write($"{col,6}  |");
        }




    }
    else
    {
        for(int col = 1; col <= cols;col++)
        {
        }



    }



    


}