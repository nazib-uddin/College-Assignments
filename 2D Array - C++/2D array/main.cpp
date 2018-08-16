# include <iostream>
using namespace std;
int main()
{
	int k[4][4], i, j;
	for (i = 0; i < 4; i++)
	{
		for (j = 0; j < 4; j++)
		{
			k[i][j] = i + j;
			cout << k[i][j]<<" ";
		}
		cout << endl;
	}
	system("pause");
	return 0;
}