using System;
namespace XiangQi{
    class general:Chess{
    
     public general(){
         
     }
        public int Rule(int x1,int y1,int x2,int y2, int player,string[,] map){
                            //确保将只能在米字格内移动
            if(map[x1,y1]==" "){
                return 0;
            }
            
            if(x2==x1&&y2==y1){
                return 0;
            }
        
            if(player==0){
                if(x2>2||y2<3||y2>5){
                    return 0;
                }

                if(System.Math.Abs(x2-x1)+System.Math.Abs(y2-y1)!=1){
                    return 0;
                }

                
            }


/////////////////////////////////////////////////////////////////////
            if(player==1){
                if(7>x2||y2<3||y2>5){
                    return 0;
                }

                if(System.Math.Abs(x2-x1)+System.Math.Abs(y2-y1)!=1){
                    return 0;
                }
            }
            return 1;
        }
        }
        }
        
    
