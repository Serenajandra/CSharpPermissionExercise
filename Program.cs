/*Se l'utente è un amministratore con un livello superiore a 55, restituire il messaggio:
Welcome, Super Admin user.

Se l'utente è un amministratore con un livello inferiore o uguale a 55, restituire il messaggio:
Welcome, Admin user.

Se l'utente è un manager con un livello pari a 20, restituire il messaggio:
Contact an Admin for access.

Se l'utente è un manager con un livello inferiore a 20, restituire il messaggio:
You do not have sufficient privileges.

Se l'utente non è un amministratore né un manager, restituire il messaggio:
You do not have sufficient privileges.*/

string permission = "Manager";
int level = 20;

if (permission.Contains("Admin"))
{
    //Se l'utente è un amministratore con un livello superiore a 55, restituire il messaggio:
    // Welcome, Super Admin user.

    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user");
    }
    // Se l'utente è un amministratore con un livello inferiore o uguale a 55, restituire il messaggio:
    // Welcome, Admin user.

    if ((level > 20) && (level <= 55))
    {
        Console.WriteLine("Welcome, Admin user");
    }
}
else if (permission.Contains("Manager"))
{
    // Se l'utente è un manager con un livello pari a 20, restituire il messaggio:
    // Contact an Admin for access.
    if (level == 20)
    {
        Console.WriteLine("Contact an Admim for access");
    }
    // Se l'utente è un manager con un livello inferiore a 20, restituire il messaggio:
    // You do not have sufficient privileges.
    if (level < 20)
    {
        Console.WriteLine("You do not have sufficient privileges");
    }
}

else
{
    Console.WriteLine("You do not have privileges");
}