namespace Sem_07 {
	public class Task_01{ 
		public static void Main (string [] args){
			Console.Write ("введите размер массива: ");
			int size = Convert.ToInt32(Console.ReadLine ());
			string [] array = new string [size];
			Console.WriteLine ("Заполним массив");
			for (int i = 0; i < size; i++){
				Console.Write ($"введите {i}-й Элемент: ");
				array [i] = Console.ReadLine();
			}
			Console.WriteLine ("Массив заполнен");
			string [] result = LessOfThreeChar (array);
			foreach (string item in result) {
                Console.Write (item + " ");
            }
		}
		public static string [] LessOfThreeChar (string[] array){
			int n = 0;
			for (int i = 0; i<array.Length; i++) {
				if (array[i].Length <= 3) n++;
			}
			string [] result = new string [n];
			int j = 0;	
			for (int i = 0; i<array.Length; i++){
				if (array[i].Length <= 3){ 
					result [j] = array[i];
					j++;	
				}
            }    
			return result;
		}
	}
}

