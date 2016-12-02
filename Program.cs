using System;

namespace xr1_3
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// 1次元配列の宣言
			int[] array1 = new int[5];

			// 宣言と初期値の代入
			int[] array2 = new int[] { 1, 2, 3, 4 };

			// 代替の宣言方法（右オペランド上でデータ型を指定しないケース）
			int[] array3 = { 2, 4, 6 };

			// 2次元配列の宣言 3行 x 2列
			int[,] twoDimArray1 = new int[3, 2];

			// 2次元配列の宣言と初期値の代入
			int[,] twoDimArray2 = { { 1, 2 }, { 2, 3 }, { 3, 4 } };

			// ジャグ配列の宣言
			int[][] jaggedArray = new int[2][];
			jaggedArray[0] = new int[] { 1, 2, 3, 4 }; jaggedArray[1] = new int[] { 9 };


			// foreachによる配列参照の例
			// 初期値未代入の配列
			Console.WriteLine("array1 = ");
			foreach (int elem in array2)
			{
				// array1は宣言のみで要素に代入していないが、初期値0が出力される
				Console.WriteLine(" {0}", elem);
			}
			// 2次元配列の場合
			Console.WriteLine("twDimeArray2 = ");
			foreach (int elem in twoDimArray2)
			{
				// twoDimArray2は2次元配列だが、1次元的に出力される
				Console.WriteLine(" {0} ", elem);
			}

		}
	}
}
