using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XyLyHoSo_Tab.Models;

namespace XyLyHoSo_Tab.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TuanPage : ContentPage
	{
        public PlotModel ModelColumnStack { get; set; }
        public TuanOxyPlotInfo oxyPlotInfo;
        public int HSDungHan=100;
        public int HSTreHan=20;
        public int HSDangXuLy=40;
        public TuanPage ()
		{
			InitializeComponent ();
            this.Init();
        }
        public void Init()
        {
            this.Title = "TUẦN";
            oxyPlotInfo = new TuanOxyPlotInfo();
            oxyPlotInfo.info = "Tổng số hồ sơ";

            List<TuanOxyPlotItem> items = new List<TuanOxyPlotItem>()
            {
            //new TuanOxyPlotItem { Label = "đúng hạn", Value = 25 , Color = OxyColor.FromRgb(255, 0, 0)},
            new TuanOxyPlotItem { Label = HSTreHan.ToString(), Value = HSTreHan , Color = OxyColor.FromRgb(255, 0, 0)},
            new TuanOxyPlotItem { Label = HSDangXuLy.ToString(), Value = HSDangXuLy , Color = OxyColor.FromRgb(255, 254, 22)},
            new TuanOxyPlotItem { Label = HSDungHan.ToString(), Value = HSDungHan , Color = OxyColor.FromRgb(0, 0, 255)}
            };
            oxyPlotInfo.Item = items;
            this.BindingContext = this.oxyPlotInfo.info;
            this.MakePlot();
        }
        public void MakePlot() //vẽ biểu đồ tròn
        {
            PlotModel plotModel = new PlotModel
            {
               // Title = "Tình hình xử lý hồ sơ trong tuần",
                TextColor = OxyColor.FromRgb(0, 0, 255),
                LegendTitleFontSize = 10

                
                
            };
            var ps = new PieSeries
            {
                StrokeThickness = .25,
                InsideLabelPosition = .25,
                AngleSpan = 360,
                StartAngle = -90,
                TextColor = OxyColor.FromRgb(100, 100, 100)
            };
            foreach (var oxyitem in oxyPlotInfo.Item)
            {
                ps.Slices.Add(new PieSlice(oxyitem.Label, oxyitem.Value) { IsExploded = false, Fill = oxyitem.Color });
            }
            plotModel.Series.Add(ps);
            this.plotmodel.Model = plotModel; 
            TuanOxyPlotColumtStack();
            this.plotcolumntstackmodel.Model = ModelColumnStack;
        }
        // khởi tạo ColumnStackChart
        private void TuanOxyPlotColumtStack()
        {
            ModelColumnStack = new PlotModel();
            ModelColumnStack.LegendBorderThickness = 0;
            ModelColumnStack.LegendOrientation = LegendOrientation.Horizontal;
            //ModelColumnStack.LegendOrientation = LegendOrientation.Vertical;
            ModelColumnStack.LegendPlacement = LegendPlacement.Outside;
            ModelColumnStack.LegendPosition = LegendPosition.BottomCenter;
            

            //ModelColumnStack.Title = "Simple stacked model";
            var categoryAxis1 = new CategoryAxis();
            categoryAxis1.MinorStep = 1;
            categoryAxis1.Labels.Add("Category A");
            categoryAxis1.Labels.Add("Category B");
            categoryAxis1.Labels.Add("Category C");
            categoryAxis1.Labels.Add("Category D");
            categoryAxis1.IsZoomEnabled = false;
            categoryAxis1.IsPanEnabled = false;
            ModelColumnStack.Axes.Add(categoryAxis1);
            var linearAxis1 = new LinearAxis();
            linearAxis1.IsZoomEnabled = false;
            linearAxis1.IsPanEnabled = false;
            linearAxis1.AbsoluteMinimum = 0;
            linearAxis1.MaximumPadding = 0.1;
            linearAxis1.MinimumPadding = 0;
            ModelColumnStack.Axes.Add(linearAxis1);
            var columnSeries1 = new ColumnSeries();
            columnSeries1.FillColor = OxyColor.FromRgb(0, 0, 255);
            columnSeries1.IsStacked = true;
            columnSeries1.StrokeThickness = 1;
            columnSeries1.Title = "Series 1";
            columnSeries1.Items.Add(new ColumnItem(25));
            columnSeries1.Items.Add(new ColumnItem(137));
            columnSeries1.Items.Add(new ColumnItem(18));
            columnSeries1.Items.Add(new ColumnItem(40));
            ModelColumnStack.Series.Add(columnSeries1);
            var columnSeries2 = new ColumnSeries();
            columnSeries2.IsStacked = true;
            columnSeries2.StrokeThickness = 1;
            columnSeries2.Title = "Series 2";
            columnSeries2.Items.Add(new ColumnItem(12));
            columnSeries2.Items.Add(new ColumnItem(14));
            columnSeries2.Items.Add(new ColumnItem(120));
            columnSeries2.Items.Add(new ColumnItem(26));
            ModelColumnStack.Series.Add(columnSeries2);
        }

        
    }
}