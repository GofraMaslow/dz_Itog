int numWords=int.Parse(TakeData("Введите количество слов: ")); 
string [] inData=new string[numWords]; 
int i=0; 

while (i<numWords){ 
    inData[i]=TakeData($"Введите {i+1}-е слово: ");
    i++;
}

Console.WriteLine("\r\nМассив элементов длинной <=3:");
PrintArray(LessThen(inData,3)); 



string TakeData (string msg) { 
    Console.Write(msg);
    return Console.ReadLine()??"ERROR";
} 


string [] LessThen (string [] inArray, int amount){ 
    int arrayLength = inArray.Length; 
    string [] result = new string[arrayLength];
    int i=0; 
    int j=0; 

    while (i<arrayLength){ 
        if (inArray[i].Length<=amount) {
            result[j]=inArray[i]; 
            j++;
        }
        i++; 
    }
    
    Array.Resize(ref result,j); 
    return result;
}

void PrintArray (string [] inArray){
    int i=1;
    int arrayLength = inArray.Length;

    if (arrayLength!=0) Console.Write("[\""+inArray[0]); 
    else Console.Write("["); 

    while (i<arrayLength){ 
        Console.Write("\",\""+inArray[i]); 
        i++;
    }

    if (arrayLength!=0) Console.WriteLine("\"]"); 
    else Console.WriteLine("]"); 
    }