//İstifadəçidən 5 ədəd daxil etməsini istə və onları massivdə saxla.
//Daha sonra bu massivdəki elementlərin ümumi cəmini ekrana çıxar.
//int[] nums = new int[5];
//int sum = 0;

//for (int i = 0; i < nums.Length; i++)
//{
//    Console.Write("Ədəd daxil et: ");
//    nums[i] = int.Parse(Console.ReadLine());
//}

//foreach (int i in nums)
//{
//    sum += i;
//}
//Console.WriteLine(sum);


//Massivdə olan bütün ədədləri böyüyə doğru sırala və ekrana çıxar.
//int[] nums = { 5,3,7,2,8,4,1};
//Array.Sort(nums);
//foreach(int i  in nums)
//{
//    Console.WriteLine(i);
//}




//Massivdə olan bütün ədədləri tərsinə çevir və ekrana çıxar.
//int[] nums = { 5, 3, 7, 2, 8, 4, 1 };
//Array.Reverse(nums);
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}





//Massivdə ən böyük və ən kiçik ədədi tap və ekrana çıxar.

//int[] nums = { 5, 3, 7, 2, 8, 4, 1 };
//Array.Sort(nums);
//Array.Reverse(nums);
//Console.WriteLine(nums[0]);
//Console.WriteLine(nums[nums.Length-1]);


//Massivdə müəyyən bir ədədin mövcud olub-olmadığını yoxla.
//Əgər varsa “tapıldı”, yoxdursa “tapılmadı” mesajı çıxar.

//using System.ComponentModel;

//int[] nums = { 5, 3, 7, 2, 8, 4, 1 };
//bool b = nums.Contains(6);
//if (b == true)
//{
//    Console.WriteLine("tapildi");
//}
//else
//{
//    Console.WriteLine("tapilmadi");
//}



//2 fərqli ədədlər massivini bir massivdə birləşdir və ekrana çıxar.
//using System.ComponentModel.DataAnnotations;

//int[] nums = { 1, 2, 3, 4, 5 };
//int[] nums2 = { 6, 7, 8, 9, 10 };
//int[] cem = new int[ nums.Length + nums2.Length ] ;
//for ( int i = 0; i < nums.Length; i++)
//{
//    cem[i] = nums[i];
//}
//for ( int i = 0;i < nums2.Length; i++)
//{
//    cem[nums.Length+i]=nums2[i]; 
//}
//foreach(int eded in cem)
//{
//    Console.WriteLine(eded);
//}



//Massivdəki təkrarlanan elementləri çıxar və unikal ədədləri ekrana yaz.
//int[] nums = { 1, 2, 3, 2, 4, 1, 5 };

//foreach( int i in nums)
//{
//    int say = 0;
//    foreach ( int j in nums)
//    {
//        if (i == j)
//        {
//            say++;
//        }

//    }
//    if (say == 1)
//    {
//        Console.WriteLine(i); 
//    }

//}


//Massivdəki bütün ədədlərin orta qiymətini hesabla və ekrana çıxar.
//int[] nums = { 1, 2, 3,4,5,1 };
//int cem = 0;
//foreach(int i  in nums)
//{
//    cem += i;
//}
//float result= (float) cem/nums.Length;
//Console.WriteLine(result);


//Massivdəki elementlərin hamısını bir stringə çevir, aralarında - qoy (məsələn: "1-2-3-4").

//int[] nums = { 1, 2, 3, 4, 5 };
//Console.WriteLine(String.Join("-", nums));


//Bir massivdəki ilk 3 elementi başqa bir masssivə köçür və yeni massivdə saxla.

//int[] nums = { 1, 2, 3, 4, 5 };
//int[] yeni =new int [3];
//for(int i = 0; i < 3; i++)
//{
//    yeni[i] = nums[i];
//}
//foreach(int x in yeni)
//{
//    Console.WriteLine(x);
//}





