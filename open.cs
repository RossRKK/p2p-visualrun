public class open
{  

	public void Main ()
	{
  
  
		if (openFileDialog1.ShowDialog () == DialogResult.OK) {
			System.IO.StreamReader sr = new 
         System.IO.StreamReader (openFileDialog1.FileName);
			MessageBox.Show (sr.ReadToEnd ());
			sr.Close ();
		}
	}
}