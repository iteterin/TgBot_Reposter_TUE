
//------------------------------------------------------------------------------

//  <auto-generated>
//      This code was generated by:
//        TerminalGuiDesigner v2.0.0.0
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// -----------------------------------------------------------------------------
namespace TgBot_Reposter_TUE {
    using System;
    using Terminal.Gui;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Drawing;
    
    
    public partial class MyView : Terminal.Gui.Window {
        
        private Terminal.Gui.FrameView frameView_tgbot;
        
        private Terminal.Gui.TextField textField_tgbot_apikey;
        
        private Terminal.Gui.Label labelName_tgbotApiKey;
        
        private Terminal.Gui.TextField textField_tgbot_apikey2;
        
        private Terminal.Gui.Label labelName_tgbot_Admin;
        
        private Terminal.Gui.TextField textField_tgbot_adminId;
        
        private Terminal.Gui.Label labelName_botlogschannel;
        
        private Terminal.Gui.TextField textfield_tgbot_logchannelid;
        
        private Terminal.Gui.CheckBox checkBox_logstochannel;
        
        private Terminal.Gui.FrameView frameView_logs;
        
        private Terminal.Gui.TextView textView;
        
        private Terminal.Gui.TextView textView2;
        
        private Terminal.Gui.FrameView frameView_tgbot_schedule;
        
        private Terminal.Gui.TabView tabView_SourceTarget;
        
        private Terminal.Gui.TableView tableView_Sources;
        
        private Terminal.Gui.Button buttonAddSource;
        
        private Terminal.Gui.Button buttonEditSource;
        
        private Terminal.Gui.Button buttonDeleteSource;
        
        private Terminal.Gui.TableView tableView_Targets;
        
        private Terminal.Gui.Button buttonAddTarget;
        
        private Terminal.Gui.Button buttonEditTarget;
        
        private Terminal.Gui.Button buttonDeleteTarget;
        
        private Terminal.Gui.TableView tableView_Scheduler;
        
        private Terminal.Gui.Button buttonAddSource3;
        
        private Terminal.Gui.Button buttonEditSource3;
        
        private Terminal.Gui.Button buttonDeleteSource3;
        
        private Terminal.Gui.Label labelName_username;
        
        private Terminal.Gui.Label labelText_username;
        
        private Terminal.Gui.TimeField timeField;
        
        private void InitializeComponent() {
            this.timeField = new Terminal.Gui.TimeField();
            this.labelText_username = new Terminal.Gui.Label();
            this.labelName_username = new Terminal.Gui.Label();
            this.buttonDeleteSource3 = new Terminal.Gui.Button();
            this.buttonEditSource3 = new Terminal.Gui.Button();
            this.buttonAddSource3 = new Terminal.Gui.Button();
            this.tableView_Scheduler = new Terminal.Gui.TableView();
            this.buttonDeleteTarget = new Terminal.Gui.Button();
            this.buttonEditTarget = new Terminal.Gui.Button();
            this.buttonAddTarget = new Terminal.Gui.Button();
            this.tableView_Targets = new Terminal.Gui.TableView();
            this.buttonDeleteSource = new Terminal.Gui.Button();
            this.buttonEditSource = new Terminal.Gui.Button();
            this.buttonAddSource = new Terminal.Gui.Button();
            this.tableView_Sources = new Terminal.Gui.TableView();
            this.tabView_SourceTarget = new Terminal.Gui.TabView();
            this.frameView_tgbot_schedule = new Terminal.Gui.FrameView();
            this.textView2 = new Terminal.Gui.TextView();
            this.textView = new Terminal.Gui.TextView();
            this.frameView_logs = new Terminal.Gui.FrameView();
            this.checkBox_logstochannel = new Terminal.Gui.CheckBox();
            this.textfield_tgbot_logchannelid = new Terminal.Gui.TextField();
            this.labelName_botlogschannel = new Terminal.Gui.Label();
            this.textField_tgbot_adminId = new Terminal.Gui.TextField();
            this.labelName_tgbot_Admin = new Terminal.Gui.Label();
            this.textField_tgbot_apikey2 = new Terminal.Gui.TextField();
            this.labelName_tgbotApiKey = new Terminal.Gui.Label();
            this.textField_tgbot_apikey = new Terminal.Gui.TextField();
            this.frameView_tgbot = new Terminal.Gui.FrameView();
            this.Width = Dim.Fill(0);
            this.Height = Dim.Fill(0);
            this.X = 0;
            this.Y = 0;
            this.Visible = true;
            this.Arrangement = (Terminal.Gui.ViewArrangement.Movable | Terminal.Gui.ViewArrangement.Overlapped);
            this.Modal = false;
            this.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Title = "Press Ctrl+Q to quit";
            this.frameView_tgbot.Width = 70;
            this.frameView_tgbot.Height = 11;
            this.frameView_tgbot.X = 1;
            this.frameView_tgbot.Y = 1;
            this.frameView_tgbot.Visible = true;
            this.frameView_tgbot.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.frameView_tgbot.Data = "frameView_tgbot";
            this.frameView_tgbot.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Title = "Telegram Bot Settings";
            this.Add(this.frameView_tgbot);
            this.textField_tgbot_apikey.Width = 5;
            this.textField_tgbot_apikey.Height = Dim.Auto();
            this.textField_tgbot_apikey.X = 13;
            this.textField_tgbot_apikey.Y = 0;
            this.textField_tgbot_apikey.Visible = true;
            this.textField_tgbot_apikey.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textField_tgbot_apikey.Secret = false;
            this.textField_tgbot_apikey.Data = "textField_tgbot_apikey";
            this.textField_tgbot_apikey.Text = "";
            this.textField_tgbot_apikey.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.textField_tgbot_apikey);
            this.labelName_tgbotApiKey.Width = Dim.Auto();
            this.labelName_tgbotApiKey.Height = 1;
            this.labelName_tgbotApiKey.X = 1;
            this.labelName_tgbotApiKey.Y = 1;
            this.labelName_tgbotApiKey.Visible = true;
            this.labelName_tgbotApiKey.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.labelName_tgbotApiKey.Data = "labelName_tgbotApiKey";
            this.labelName_tgbotApiKey.Text = "Bot API key:";
            this.labelName_tgbotApiKey.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.labelName_tgbotApiKey);
            this.textField_tgbot_apikey2.Width = Dim.Fill(1);
            this.textField_tgbot_apikey2.Height = 1;
            this.textField_tgbot_apikey2.X = 14;
            this.textField_tgbot_apikey2.Y = 1;
            this.textField_tgbot_apikey2.Visible = true;
            this.textField_tgbot_apikey2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textField_tgbot_apikey2.Secret = true;
            this.textField_tgbot_apikey2.Data = "textField_tgbot_apikey2";
            this.textField_tgbot_apikey2.Text = "";
            this.textField_tgbot_apikey2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.textField_tgbot_apikey2);
            this.labelName_tgbot_Admin.Width = Dim.Auto();
            this.labelName_tgbot_Admin.Height = 1;
            this.labelName_tgbot_Admin.X = 1;
            this.labelName_tgbot_Admin.Y = 3;
            this.labelName_tgbot_Admin.Visible = true;
            this.labelName_tgbot_Admin.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.labelName_tgbot_Admin.Data = "labelName_tgbot_Admin";
            this.labelName_tgbot_Admin.Text = "Bot admin ID:";
            this.labelName_tgbot_Admin.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.labelName_tgbot_Admin);
            this.textField_tgbot_adminId.Width = Dim.Fill(1);
            this.textField_tgbot_adminId.Height = 1;
            this.textField_tgbot_adminId.X = 15;
            this.textField_tgbot_adminId.Y = 3;
            this.textField_tgbot_adminId.Visible = true;
            this.textField_tgbot_adminId.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textField_tgbot_adminId.Secret = false;
            this.textField_tgbot_adminId.Data = "textField_tgbot_adminId";
            this.textField_tgbot_adminId.Text = "Input TG admin @name or ID";
            this.textField_tgbot_adminId.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.textField_tgbot_adminId);
            this.labelName_botlogschannel.Width = Dim.Auto();
            this.labelName_botlogschannel.Height = 1;
            this.labelName_botlogschannel.X = 1;
            this.labelName_botlogschannel.Y = 5;
            this.labelName_botlogschannel.Visible = true;
            this.labelName_botlogschannel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.labelName_botlogschannel.Data = "labelName_botlogschannel";
            this.labelName_botlogschannel.Text = "Bot logs channel:";
            this.labelName_botlogschannel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.labelName_botlogschannel);
            this.textfield_tgbot_logchannelid.Width = Dim.Fill(1);
            this.textfield_tgbot_logchannelid.Height = 1;
            this.textfield_tgbot_logchannelid.X = 19;
            this.textfield_tgbot_logchannelid.Y = 5;
            this.textfield_tgbot_logchannelid.Visible = true;
            this.textfield_tgbot_logchannelid.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textfield_tgbot_logchannelid.Secret = false;
            this.textfield_tgbot_logchannelid.Data = "textfield_tgbot_logchannelid";
            this.textfield_tgbot_logchannelid.Text = "Input TG channel ID or @name";
            this.textfield_tgbot_logchannelid.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot.Add(this.textfield_tgbot_logchannelid);
            this.checkBox_logstochannel.Width = Dim.Auto();
            this.checkBox_logstochannel.Height = 1;
            this.checkBox_logstochannel.X = 1;
            this.checkBox_logstochannel.Y = 7;
            this.checkBox_logstochannel.Visible = true;
            this.checkBox_logstochannel.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.checkBox_logstochannel.Data = "checkBox_logstochannel";
            this.checkBox_logstochannel.Text = "Send logs to TG chennel";
            this.checkBox_logstochannel.TextAlignment = Terminal.Gui.Alignment.Start;
            this.checkBox_logstochannel.CheckedState = Terminal.Gui.CheckState.UnChecked;
            this.frameView_tgbot.Add(this.checkBox_logstochannel);
            this.frameView_logs.Width = 133;
            this.frameView_logs.Height = 38;
            this.frameView_logs.X = 73;
            this.frameView_logs.Y = 1;
            this.frameView_logs.Visible = true;
            this.frameView_logs.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.frameView_logs.Data = "frameView_logs";
            this.frameView_logs.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_logs.Title = "Logs";
            this.Add(this.frameView_logs);
            this.textView.Width = 0;
            this.textView.Height = Dim.Fill(0);
            this.textView.X = 0;
            this.textView.Y = 0;
            this.textView.Visible = true;
            this.textView.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textView.AllowsTab = true;
            this.textView.AllowsReturn = true;
            this.textView.WordWrap = false;
            this.textView.Data = "textView";
            this.textView.Text = "";
            this.textView.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_logs.Add(this.textView);
            this.textView2.Width = Dim.Fill(1);
            this.textView2.Height = Dim.Fill(1);
            this.textView2.X = 1;
            this.textView2.Y = 1;
            this.textView2.Visible = true;
            this.textView2.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.textView2.AllowsTab = true;
            this.textView2.AllowsReturn = true;
            this.textView2.WordWrap = true;
            this.textView2.Data = "textView2";
            this.textView2.Text = "Content logs";
            this.textView2.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_logs.Add(this.textView2);
            this.frameView_tgbot_schedule.Width = 70;
            this.frameView_tgbot_schedule.Height = 26;
            this.frameView_tgbot_schedule.X = 1;
            this.frameView_tgbot_schedule.Y = 13;
            this.frameView_tgbot_schedule.Visible = true;
            this.frameView_tgbot_schedule.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.frameView_tgbot_schedule.Data = "frameView_tgbot_schedule";
            this.frameView_tgbot_schedule.TextAlignment = Terminal.Gui.Alignment.Start;
            this.frameView_tgbot_schedule.Title = "Telegram Bot Schedule";
            this.Add(this.frameView_tgbot_schedule);
            this.tabView_SourceTarget.Width = 65;
            this.tabView_SourceTarget.Height = 23;
            this.tabView_SourceTarget.X = 1;
            this.tabView_SourceTarget.Y = 0;
            this.tabView_SourceTarget.Visible = true;
            this.tabView_SourceTarget.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.tabView_SourceTarget.Data = "tabView_SourceTarget";
            this.tabView_SourceTarget.TextAlignment = Terminal.Gui.Alignment.Start;
            this.tabView_SourceTarget.MaxTabTextWidth = 30u;
            this.tabView_SourceTarget.Style.ShowBorder = true;
            this.tabView_SourceTarget.Style.ShowTopLine = true;
            this.tabView_SourceTarget.Style.TabsOnBottom = false;
            Terminal.Gui.Tab tabView_SourceTargetsources;
            tabView_SourceTargetsources = new Terminal.Gui.Tab();
            tabView_SourceTargetsources.DisplayText = "Sources";
            tabView_SourceTargetsources.View = new View();
            tabView_SourceTargetsources.View.Width = Dim.Fill();
            tabView_SourceTargetsources.View.Height = Dim.Fill();
            this.tableView_Sources.Width = Dim.Fill(1);
            this.tableView_Sources.Height = Dim.Fill(1);
            this.tableView_Sources.X = 0;
            this.tableView_Sources.Y = 0;
            this.tableView_Sources.Visible = true;
            this.tableView_Sources.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.tableView_Sources.Data = "tableView_Sources";
            this.tableView_Sources.TextAlignment = Terminal.Gui.Alignment.Start;
            this.tableView_Sources.FullRowSelect = false;
            this.tableView_Sources.Style.AlwaysShowHeaders = false;
            this.tableView_Sources.Style.ExpandLastColumn = true;
            this.tableView_Sources.Style.InvertSelectedCellFirstCharacter = false;
            this.tableView_Sources.Style.ShowHorizontalHeaderOverline = true;
            this.tableView_Sources.Style.ShowHorizontalHeaderUnderline = true;
            this.tableView_Sources.Style.ShowVerticalCellLines = true;
            this.tableView_Sources.Style.ShowVerticalHeaderLines = true;
            System.Data.DataTable tableView_SourcesTable;
            tableView_SourcesTable = new System.Data.DataTable();
            System.Data.DataColumn tableView_SourcesTableID;
            tableView_SourcesTableID = new System.Data.DataColumn();
            tableView_SourcesTableID.ColumnName = "ID";
            tableView_SourcesTable.Columns.Add(tableView_SourcesTableID);
            System.Data.DataColumn tableView_SourcesTableName;
            tableView_SourcesTableName = new System.Data.DataColumn();
            tableView_SourcesTableName.ColumnName = "Name";
            tableView_SourcesTable.Columns.Add(tableView_SourcesTableName);
            System.Data.DataColumn tableView_SourcesTableAddDate;
            tableView_SourcesTableAddDate = new System.Data.DataColumn();
            tableView_SourcesTableAddDate.ColumnName = "Add Date";
            tableView_SourcesTable.Columns.Add(tableView_SourcesTableAddDate);
            System.Data.DataColumn tableView_SourcesTableComment;
            tableView_SourcesTableComment = new System.Data.DataColumn();
            tableView_SourcesTableComment.ColumnName = "Comment";
            tableView_SourcesTable.Columns.Add(tableView_SourcesTableComment);
            this.tableView_Sources.Table = new Terminal.Gui.DataTableSource(tableView_SourcesTable);
            tabView_SourceTargetsources.View.Add(this.tableView_Sources);
            this.buttonAddSource.Width = Dim.Auto();
            this.buttonAddSource.Height = 1;
            this.buttonAddSource.X = 1;
            this.buttonAddSource.Y = 18;
            this.buttonAddSource.Visible = true;
            this.buttonAddSource.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonAddSource.Data = "buttonAddSource";
            this.buttonAddSource.Text = "Add";
            this.buttonAddSource.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonAddSource.IsDefault = false;
            tabView_SourceTargetsources.View.Add(this.buttonAddSource);
            this.buttonEditSource.Width = Dim.Auto();
            this.buttonEditSource.Height = 1;
            this.buttonEditSource.X = 9;
            this.buttonEditSource.Y = 18;
            this.buttonEditSource.Visible = true;
            this.buttonEditSource.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonEditSource.Data = "buttonEditSource";
            this.buttonEditSource.Text = "Edit";
            this.buttonEditSource.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonEditSource.IsDefault = false;
            tabView_SourceTargetsources.View.Add(this.buttonEditSource);
            this.buttonDeleteSource.Width = Dim.Auto();
            this.buttonDeleteSource.Height = 1;
            this.buttonDeleteSource.X = 52;
            this.buttonDeleteSource.Y = 18;
            this.buttonDeleteSource.Visible = true;
            this.buttonDeleteSource.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonDeleteSource.Data = "buttonDeleteSource";
            this.buttonDeleteSource.Text = "Delete";
            this.buttonDeleteSource.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonDeleteSource.IsDefault = false;
            tabView_SourceTargetsources.View.Add(this.buttonDeleteSource);
            tabView_SourceTarget.AddTab(tabView_SourceTargetsources, false);
            Terminal.Gui.Tab tabView_SourceTargettargets;
            tabView_SourceTargettargets = new Terminal.Gui.Tab();
            tabView_SourceTargettargets.DisplayText = "Targets";
            tabView_SourceTargettargets.View = new View();
            tabView_SourceTargettargets.View.Width = Dim.Fill();
            tabView_SourceTargettargets.View.Height = Dim.Fill();
            this.tableView_Targets.Width = Dim.Fill(1);
            this.tableView_Targets.Height = Dim.Fill(1);
            this.tableView_Targets.X = 0;
            this.tableView_Targets.Y = 0;
            this.tableView_Targets.Visible = true;
            this.tableView_Targets.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.tableView_Targets.Data = "tableView_Targets";
            this.tableView_Targets.TextAlignment = Terminal.Gui.Alignment.Start;
            this.tableView_Targets.FullRowSelect = false;
            this.tableView_Targets.Style.AlwaysShowHeaders = false;
            this.tableView_Targets.Style.ExpandLastColumn = true;
            this.tableView_Targets.Style.InvertSelectedCellFirstCharacter = false;
            this.tableView_Targets.Style.ShowHorizontalHeaderOverline = true;
            this.tableView_Targets.Style.ShowHorizontalHeaderUnderline = true;
            this.tableView_Targets.Style.ShowVerticalCellLines = true;
            this.tableView_Targets.Style.ShowVerticalHeaderLines = true;
            System.Data.DataTable tableView_TargetsTable;
            tableView_TargetsTable = new System.Data.DataTable();
            System.Data.DataColumn tableView_TargetsTableID;
            tableView_TargetsTableID = new System.Data.DataColumn();
            tableView_TargetsTableID.ColumnName = "ID";
            tableView_TargetsTable.Columns.Add(tableView_TargetsTableID);
            System.Data.DataColumn tableView_TargetsTableName;
            tableView_TargetsTableName = new System.Data.DataColumn();
            tableView_TargetsTableName.ColumnName = "Name";
            tableView_TargetsTable.Columns.Add(tableView_TargetsTableName);
            System.Data.DataColumn tableView_TargetsTableAddDate;
            tableView_TargetsTableAddDate = new System.Data.DataColumn();
            tableView_TargetsTableAddDate.ColumnName = "Add Date";
            tableView_TargetsTable.Columns.Add(tableView_TargetsTableAddDate);
            System.Data.DataColumn tableView_TargetsTableComment;
            tableView_TargetsTableComment = new System.Data.DataColumn();
            tableView_TargetsTableComment.ColumnName = "Comment";
            tableView_TargetsTable.Columns.Add(tableView_TargetsTableComment);
            this.tableView_Targets.Table = new Terminal.Gui.DataTableSource(tableView_TargetsTable);
            tabView_SourceTargettargets.View.Add(this.tableView_Targets);
            this.buttonAddTarget.Width = Dim.Auto();
            this.buttonAddTarget.Height = 1;
            this.buttonAddTarget.X = 1;
            this.buttonAddTarget.Y = 18;
            this.buttonAddTarget.Visible = true;
            this.buttonAddTarget.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonAddTarget.Data = "buttonAddTarget";
            this.buttonAddTarget.Text = "Add";
            this.buttonAddTarget.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonAddTarget.IsDefault = false;
            tabView_SourceTargettargets.View.Add(this.buttonAddTarget);
            this.buttonEditTarget.Width = Dim.Auto();
            this.buttonEditTarget.Height = 1;
            this.buttonEditTarget.X = 9;
            this.buttonEditTarget.Y = 18;
            this.buttonEditTarget.Visible = true;
            this.buttonEditTarget.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonEditTarget.Data = "buttonEditTarget";
            this.buttonEditTarget.Text = "Edit";
            this.buttonEditTarget.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonEditTarget.IsDefault = false;
            tabView_SourceTargettargets.View.Add(this.buttonEditTarget);
            this.buttonDeleteTarget.Width = Dim.Auto();
            this.buttonDeleteTarget.Height = 1;
            this.buttonDeleteTarget.X = 52;
            this.buttonDeleteTarget.Y = 18;
            this.buttonDeleteTarget.Visible = true;
            this.buttonDeleteTarget.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonDeleteTarget.Data = "buttonDeleteTarget";
            this.buttonDeleteTarget.Text = "Delete";
            this.buttonDeleteTarget.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonDeleteTarget.IsDefault = false;
            tabView_SourceTargettargets.View.Add(this.buttonDeleteTarget);
            tabView_SourceTarget.AddTab(tabView_SourceTargettargets, false);
            Terminal.Gui.Tab tabView_SourceTargetscheduler;
            tabView_SourceTargetscheduler = new Terminal.Gui.Tab();
            tabView_SourceTargetscheduler.DisplayText = "Scheduler";
            tabView_SourceTargetscheduler.View = new View();
            tabView_SourceTargetscheduler.View.Width = Dim.Fill();
            tabView_SourceTargetscheduler.View.Height = Dim.Fill();
            this.tableView_Scheduler.Width = Dim.Fill(1);
            this.tableView_Scheduler.Height = Dim.Fill(1);
            this.tableView_Scheduler.X = 0;
            this.tableView_Scheduler.Y = 0;
            this.tableView_Scheduler.Visible = true;
            this.tableView_Scheduler.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.tableView_Scheduler.Data = "tableView_Scheduler";
            this.tableView_Scheduler.TextAlignment = Terminal.Gui.Alignment.Start;
            this.tableView_Scheduler.FullRowSelect = false;
            this.tableView_Scheduler.Style.AlwaysShowHeaders = false;
            this.tableView_Scheduler.Style.ExpandLastColumn = true;
            this.tableView_Scheduler.Style.InvertSelectedCellFirstCharacter = false;
            this.tableView_Scheduler.Style.ShowHorizontalHeaderOverline = true;
            this.tableView_Scheduler.Style.ShowHorizontalHeaderUnderline = true;
            this.tableView_Scheduler.Style.ShowVerticalCellLines = true;
            this.tableView_Scheduler.Style.ShowVerticalHeaderLines = true;
            System.Data.DataTable tableView_SchedulerTable;
            tableView_SchedulerTable = new System.Data.DataTable();
            System.Data.DataColumn tableView_SchedulerTableSource;
            tableView_SchedulerTableSource = new System.Data.DataColumn();
            tableView_SchedulerTableSource.ColumnName = "Source";
            tableView_SchedulerTable.Columns.Add(tableView_SchedulerTableSource);
            System.Data.DataColumn tableView_SchedulerTableTarget;
            tableView_SchedulerTableTarget = new System.Data.DataColumn();
            tableView_SchedulerTableTarget.ColumnName = "Target";
            tableView_SchedulerTable.Columns.Add(tableView_SchedulerTableTarget);
            System.Data.DataColumn tableView_SchedulerTableWeekDays;
            tableView_SchedulerTableWeekDays = new System.Data.DataColumn();
            tableView_SchedulerTableWeekDays.ColumnName = "WeekDays";
            tableView_SchedulerTable.Columns.Add(tableView_SchedulerTableWeekDays);
            System.Data.DataColumn tableView_SchedulerTableTime;
            tableView_SchedulerTableTime = new System.Data.DataColumn();
            tableView_SchedulerTableTime.ColumnName = "Time";
            tableView_SchedulerTable.Columns.Add(tableView_SchedulerTableTime);
            System.Data.DataColumn tableView_SchedulerTableComment;
            tableView_SchedulerTableComment = new System.Data.DataColumn();
            tableView_SchedulerTableComment.ColumnName = "Comment";
            tableView_SchedulerTable.Columns.Add(tableView_SchedulerTableComment);
            this.tableView_Scheduler.Table = new Terminal.Gui.DataTableSource(tableView_SchedulerTable);
            tabView_SourceTargetscheduler.View.Add(this.tableView_Scheduler);
            this.buttonAddSource3.Width = Dim.Auto();
            this.buttonAddSource3.Height = 1;
            this.buttonAddSource3.X = 1;
            this.buttonAddSource3.Y = 18;
            this.buttonAddSource3.Visible = true;
            this.buttonAddSource3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonAddSource3.Data = "buttonAddSource3";
            this.buttonAddSource3.Text = "Add";
            this.buttonAddSource3.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonAddSource3.IsDefault = false;
            tabView_SourceTargetscheduler.View.Add(this.buttonAddSource3);
            this.buttonEditSource3.Width = Dim.Auto();
            this.buttonEditSource3.Height = 1;
            this.buttonEditSource3.X = 9;
            this.buttonEditSource3.Y = 18;
            this.buttonEditSource3.Visible = true;
            this.buttonEditSource3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonEditSource3.Data = "buttonEditSource3";
            this.buttonEditSource3.Text = "Edit";
            this.buttonEditSource3.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonEditSource3.IsDefault = false;
            tabView_SourceTargetscheduler.View.Add(this.buttonEditSource3);
            this.buttonDeleteSource3.Width = Dim.Auto();
            this.buttonDeleteSource3.Height = 1;
            this.buttonDeleteSource3.X = 52;
            this.buttonDeleteSource3.Y = 18;
            this.buttonDeleteSource3.Visible = true;
            this.buttonDeleteSource3.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.buttonDeleteSource3.Data = "buttonDeleteSource3";
            this.buttonDeleteSource3.Text = "Delete";
            this.buttonDeleteSource3.TextAlignment = Terminal.Gui.Alignment.Center;
            this.buttonDeleteSource3.IsDefault = false;
            tabView_SourceTargetscheduler.View.Add(this.buttonDeleteSource3);
            tabView_SourceTarget.AddTab(tabView_SourceTargetscheduler, false);
            this.tabView_SourceTarget.ApplyStyleChanges();
            this.frameView_tgbot_schedule.Add(this.tabView_SourceTarget);
            this.labelName_username.Width = Dim.Auto();
            this.labelName_username.Height = 1;
            this.labelName_username.X = 1;
            this.labelName_username.Y = 51;
            this.labelName_username.Visible = true;
            this.labelName_username.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.labelName_username.Data = "labelName_username";
            this.labelName_username.Text = "UserName:";
            this.labelName_username.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.labelName_username);
            this.labelText_username.Width = Dim.Auto();
            this.labelText_username.Height = 1;
            this.labelText_username.X = 11;
            this.labelText_username.Y = 51;
            this.labelText_username.Visible = true;
            this.labelText_username.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.labelText_username.Data = "labelText_username";
            this.labelText_username.Text = "%username%";
            this.labelText_username.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.labelText_username);
            this.timeField.Width = 10;
            this.timeField.Height = 1;
            this.timeField.X = 196;
            this.timeField.Y = 51;
            this.timeField.Visible = true;
            this.timeField.Arrangement = Terminal.Gui.ViewArrangement.Fixed;
            this.timeField.Secret = false;
            this.timeField.Data = "timeField";
            this.timeField.Text = " 02:48:05";
            this.timeField.TextAlignment = Terminal.Gui.Alignment.Start;
            this.Add(this.timeField);
        }
    }
}
