// i<j<k
// a[j]-a[i] = a[k]-a[j] = d
// this leads us to 2*a[j] = a[k]+a[i] = d

int[] arr = {2,2,3,4,5};
int result = 0;

for(int i=0; i<=arr.Length-3; i++){
    for(int j=i+1; j<=arr.Length-2; j++){
        for(int k=j+1; k<=arr.Length-1; k++){
            if(2*arr[j]==arr[k]+arr[i]){
                result++;
            }
            System.Console.WriteLine("i: " + i.ToString());
            System.Console.WriteLine("j: " + j.ToString());
            System.Console.WriteLine("k: " + k.ToString());
            System.Console.WriteLine("---------");

        }
    }
}
System.Console.WriteLine(result);