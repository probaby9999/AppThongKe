﻿using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Collections.Generic;
using System.Text;

namespace XyLyHoSo_Tab.Models
{
    class TuanOxyPlotColumtStack
    {
        public PlotModel ModelColumnStack { get; set; }
        public TuanOxyPlotColumtStack()
        {
            ModelColumnStack = new PlotModel();
            ModelColumnStack.LegendBorderThickness = 0;
            ModelColumnStack.LegendOrientation = LegendOrientation.Horizontal;
            ModelColumnStack.LegendPlacement = LegendPlacement.Outside;
            ModelColumnStack.LegendPosition = LegendPosition.BottomCenter;
            ModelColumnStack.Title = "Simple stacked model";
            var categoryAxis1 = new CategoryAxis();
            categoryAxis1.MinorStep = 1;
            categoryAxis1.Labels.Add("Category A");
            categoryAxis1.Labels.Add("Category B");
            categoryAxis1.Labels.Add("Category C");
            categoryAxis1.Labels.Add("Category D");
            ModelColumnStack.Axes.Add(categoryAxis1);
            var linearAxis1 = new LinearAxis();
            linearAxis1.AbsoluteMinimum = 0;
            linearAxis1.MaximumPadding = 0.06;
            linearAxis1.MinimumPadding = 0;
            ModelColumnStack.Axes.Add(linearAxis1);
            var columnSeries1 = new ColumnSeries();
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
