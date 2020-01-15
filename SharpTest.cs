// TTTTTest
private void Button1_Click(object sender, EventArgs e)
{
  int[] arr = new int[1000]; // int array
  
  // Eingabe string
  string eingabe;
  eingabe = textBox1.Text;
  
  // Zahlenstrings mit Komma getrennt ins int array
  string[] tokens = eingabe.Split(','); 
  for (int i = 0; i < arr.Length && i < tokens.Length; i++)
  { 
    arr[i] = Convert.ToInt32(tokens[i]);
  }
  
  //Bubblesort
  int temp = 0; 
  for (int write = 0; write < tokens.Length; write++)    
  {
    for (int sort = 0; sort < tokens.Length - 1; sort++)
    { 
      if (arr[sort] > arr[sort + 1])  
      {
        temp = arr[sort + 1];
        arr[sort + 1] = arr[sort];
        arr[sort] = temp;                    
      } 
    }
  } 
  
  // Ausgabe im label
  label1.Text = ""; 
  for (int i = 0; i < tokens.Length; i++) 
  { 
    label1.Text += Convert.ToString(arr[i]);
    label1.Text += " ";  
  } 
}
