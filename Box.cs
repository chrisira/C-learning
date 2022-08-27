
namespace constructor_properties1
{
    class Box
    {
        //member variables 
        private int length = 3;
        private int height;
        //public int width;
        private int volume;


    public int Width { get; set; }
        
    public int Height
    {
    get
    {
        return height;
    }
    set{
        if(value < 0 ){
            height = -value;
        }
        else
        {
          height = value;

        }
    }
    }
    public int frontSurface
    {
        get{
            return Width * Height;
        }
    }

    public int Volume
    {
        get{
            return Width * length * Height;
        }
        set{
            this.Volume = value;
        }
    }

    public Box(int length,int width,int height){
        this.length = length;
        this.Height = height;
        this.Width = width;
    }

      public Box(int height,int width){
        this.Height = height;
        this.Width = width;
    }
        public void SetLength(int length){
            if(length < 0 ){
                throw new Exception("The length must be gerater than 0");
            }
            this.length = length;
        }

        public int GetLength(){
            return this.length;
        }

        public void DisplayInfo(){
            System.Console.WriteLine("The length is {0} height is  {1} width is {2} and width is {3}"
            ,length,height,Width,GetVolume());
        }
        
        public int GetVolume(){
            return this.Width * this.length * this.height;
        }
    }
}