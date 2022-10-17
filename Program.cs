using System;

namespace flod{
    class program{
        static void Main(){
          // program ska ta ett random tall fån 0 till 100
            Random r= new Random();
            int tal= r.Next(0, 100);
            
            // inom ett loop gisning spelet körs, siff är siffran som användare gissar
            // med hjälp av if-statement jämför programet siff, om det är samma som tal är svaret rätt och antal försök skrivs ut.
            // om talet för lågt eller högt kan man gissar igen tills man får rätt svar och antal försök skrivs ut.

            for(int i=0; i>=0;i++){
            Console.WriteLine("gissa heltalet:");
              int siff= Convert.ToInt32(Console.ReadLine());
             if (siff==tal){
             Console.WriteLine("rätt svar!");
              Console.WriteLine("antal försök:"+(i+1)); 
             break;
             } 
        else if(siff>tal)
        Console.WriteLine("talet är förhögt");
        else
        Console.WriteLine("talet är förlågt");
    
       }
    }
  }
 }