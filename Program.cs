using Structures;
using System.Collections;

ArrayList arrayList1 = new ArrayList();
arrayList1.Add(1);
arrayList1.Add(3.2);
arrayList1.AddRange(new string[] { "Hello world" });
arrayList1.Add("Alona");

for (int i = 0; i < arrayList1.Count; i++)
{
    Console.Write(arrayList1[i]?.ToString() + " ");
}


