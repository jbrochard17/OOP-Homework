namespace TempApp
{
    public class Temperature
    {
        public float[] temperatures = new float[10];
        public int dataSize = 0;

        public Temperature(float temp){
            temperatures[0] = temp;
            dataSize = 1;
        }
        
        public void add(float temp){
            temperatures[dataSize] = temp;
            dataSize += 1;
        }
        
        public float minimum(){
            float min = temperatures[0];
            for (int i=1; i<dataSize; i++){
                if(temperatures[i]<min){
                    min = temperatures[i];
                }
            }
            return min;
        }
        
        public float minimumUntil(int a){
            float min = temperatures[0];
            for(int i=1; i<a; i++){
                if(temperatures[i]<min){
                    min = temperatures[i];
                }
            }
            return min;
        }
        
        public float maximum(){
            float max = temperatures[0];
            for(int i=0; i<dataSize; i++){
                if(temperatures[i]>max){
                    max = temperatures[i];
                }
            }
            return max;
        }
        
        public float average(){
            float sum = 0;
            for(int i=0; i<dataSize; i++){
                sum += temperatures[i];
            }
            return sum/dataSize;
        }
        
        public float[] allAbove(float tresh){
            float[] toreturn = new float[10];
            int sz = 0;
            for (int i=0; i<dataSize; i++){
                if (temperatures[i] > tresh){
                toreturn[sz] = temperatures[i];
                sz++;
                }
            }
            return toreturn;
        }
    }
}