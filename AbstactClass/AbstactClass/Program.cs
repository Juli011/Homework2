using AbstactClass.Models;
using AbstactClass.Const;

ColumnRound columnRound = new ColumnRound(0.01,1, Material.Steel);
columnRound.Description();
columnRound.Message(columnRound.TypeOfDeformation(100));