#region Gen0 optimizations

using System.Collections;
using System.Text;

void OptimizeStrBuilder()
{
	//problem
	var s = new StringBuilder();
	for (int i = 0; i < 10000; i++)
		s.Append(i.ToString() + "KB");

	//solution
	var sb = new StringBuilder(); 
	for (int i = 0; i < 10000; i++) //ga perlu pake to string lagi
	{
		sb.Append(i); //append untuk string builder sudah memuat string
		sb.Append("KB");
	}

}

void OptmList()
{
	//problem
	var array = new ArrayList(); // kalau pake arraylist aja, saat diappend nanti akan ada kelebihan indeks
	// list sizenya ada 4, kalo udah full dan nambah lagi, dia akan menambah ruang baru menjadi 8 walapun yang ditambah hanya satu variabel
	for (int i = 0; i < 10000; i++)
		array.Add(i);

	//solution
	var list = new List<int>(); //mending langsung diassign aja size listnya
	for (int i = 0; i < 10000; i++)
		list.Add(i);
}

void ObjectsInstanciation()
{
	//problem
	MyClass myclass = new MyClass();
	//lots of other code... //alasan: object di atas terpanggilnya di akhir, jadi dia akan alive di gen 2, mending ditaro sebelum digunakan
	UseTheObject(myclass);

	//solution 
	MyClass obj = new MyClass();
	UseTheObject(obj);
}
#endregion

#region Size Strategies

void ReduceSizeToKeepShortLived()
{
	//problem
	var buffer = new int[32768]; //int bytenya 4
	for (int i = 0; i < buffer.Length; i++)
		buffer[i] = GetByte(i);

	//solution
	var otherBuffer = new byte[32768]; //mending langsung aja pake byte
	for (int i = 0; i < otherBuffer.Length; i++)
		otherBuffer[i] = GetByte(i);
}

void IncreaseSizeToKeepLongLived()
{
	//problem
	var list = new ArrayList(); //array sizenya kan awal 4, terus 8, terus 16,...
	//lots of other code!
	UseTheList(list);

	//solution
	var list2 = new ArrayList(85190); //langsung aja assign sizenya
	//lots of other code!
	UseTheList(list2);

}
#endregion
#region empty definitions

//methods created only for completing the examples!

void UseTheList(ArrayList list)
{
	throw new NotImplementedException();
}
void UseTheObject(object o)
{
	throw new NotImplementedException();
}
byte GetByte(int i)
{
	throw new NotImplementedException();
}

class Pair
{
	public Pair(int x, int y)
	{
		throw new NotImplementedException();
	}
}

public class MyClass
{
}


#endregion