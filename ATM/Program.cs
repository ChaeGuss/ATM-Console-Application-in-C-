using System;

public class cardHolder {
    String cardNumber;
    int pin;
    String firstName;
    String lastName;
    double balance;

    public cardHolder(string cardNum, int pin, String firstName, String lastName, double balance)
    {
        this.cardNumber = cardNum;
        this.pin = 0;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;
            
    }
}