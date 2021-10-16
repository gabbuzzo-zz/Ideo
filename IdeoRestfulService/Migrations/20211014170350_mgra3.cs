using Microsoft.EntityFrameworkCore.Migrations;

namespace IdeoRestfulService.Migrations
{
    public partial class mgra3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_AspNetUsers_UserId",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_Message_MessageId",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplication_Post_PostId",
                table: "JobApplication");

            migrationBuilder.DropForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_JobApplication_JobApplicationId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Report_ReportType_ReportTypeId",
                table: "Report");

            migrationBuilder.DropForeignKey(
                name: "FK_Tag_Post_PostId",
                table: "Tag");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoCourse_AspNetUsers_UserId",
                table: "VideoCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoCourse",
                table: "VideoCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tag",
                table: "Tag");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportType",
                table: "ReportType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Report",
                table: "Report");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Message",
                table: "Message");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobApplication",
                table: "JobApplication");

            migrationBuilder.RenameTable(
                name: "VideoCourse",
                newName: "VideoCourses");

            migrationBuilder.RenameTable(
                name: "Tag",
                newName: "Tags");

            migrationBuilder.RenameTable(
                name: "ReportType",
                newName: "ReportTypes");

            migrationBuilder.RenameTable(
                name: "Report",
                newName: "Reports");

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "Posts");

            migrationBuilder.RenameTable(
                name: "Message",
                newName: "Messages");

            migrationBuilder.RenameTable(
                name: "JobApplication",
                newName: "JobApplications");

            migrationBuilder.RenameIndex(
                name: "IX_VideoCourse_UserId",
                table: "VideoCourses",
                newName: "IX_VideoCourses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tag_PostId",
                table: "Tags",
                newName: "IX_Tags_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_ReportTypeId",
                table: "Reports",
                newName: "IX_Reports_ReportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Report_JobApplicationId",
                table: "Reports",
                newName: "IX_Reports_JobApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Post_UserId",
                table: "Posts",
                newName: "IX_Posts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Message_UserId",
                table: "Messages",
                newName: "IX_Messages_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplication_UserId",
                table: "JobApplications",
                newName: "IX_JobApplications_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplication_PostId",
                table: "JobApplications",
                newName: "IX_JobApplications_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplication_MessageId",
                table: "JobApplications",
                newName: "IX_JobApplications_MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoCourses",
                table: "VideoCourses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tags",
                table: "Tags",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reports",
                table: "Reports",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Posts",
                table: "Posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Messages",
                table: "Messages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobApplications",
                table: "JobApplications",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_AspNetUsers_UserId",
                table: "JobApplications",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Messages_MessageId",
                table: "JobApplications",
                column: "MessageId",
                principalTable: "Messages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplications_Posts_PostId",
                table: "JobApplications",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_JobApplications_JobApplicationId",
                table: "Reports",
                column: "JobApplicationId",
                principalTable: "JobApplications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reports_ReportTypes_ReportTypeId",
                table: "Reports",
                column: "ReportTypeId",
                principalTable: "ReportTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoCourses_AspNetUsers_UserId",
                table: "VideoCourses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_AspNetUsers_UserId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Messages_MessageId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_JobApplications_Posts_PostId",
                table: "JobApplications");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_AspNetUsers_UserId",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_UserId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_JobApplications_JobApplicationId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Reports_ReportTypes_ReportTypeId",
                table: "Reports");

            migrationBuilder.DropForeignKey(
                name: "FK_Tags_Posts_PostId",
                table: "Tags");

            migrationBuilder.DropForeignKey(
                name: "FK_VideoCourses_AspNetUsers_UserId",
                table: "VideoCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VideoCourses",
                table: "VideoCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tags",
                table: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReportTypes",
                table: "ReportTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reports",
                table: "Reports");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Posts",
                table: "Posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Messages",
                table: "Messages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobApplications",
                table: "JobApplications");

            migrationBuilder.RenameTable(
                name: "VideoCourses",
                newName: "VideoCourse");

            migrationBuilder.RenameTable(
                name: "Tags",
                newName: "Tag");

            migrationBuilder.RenameTable(
                name: "ReportTypes",
                newName: "ReportType");

            migrationBuilder.RenameTable(
                name: "Reports",
                newName: "Report");

            migrationBuilder.RenameTable(
                name: "Posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "Messages",
                newName: "Message");

            migrationBuilder.RenameTable(
                name: "JobApplications",
                newName: "JobApplication");

            migrationBuilder.RenameIndex(
                name: "IX_VideoCourses_UserId",
                table: "VideoCourse",
                newName: "IX_VideoCourse_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Tags_PostId",
                table: "Tag",
                newName: "IX_Tag_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_ReportTypeId",
                table: "Report",
                newName: "IX_Report_ReportTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Reports_JobApplicationId",
                table: "Report",
                newName: "IX_Report_JobApplicationId");

            migrationBuilder.RenameIndex(
                name: "IX_Posts_UserId",
                table: "Post",
                newName: "IX_Post_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Messages_UserId",
                table: "Message",
                newName: "IX_Message_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_UserId",
                table: "JobApplication",
                newName: "IX_JobApplication_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_PostId",
                table: "JobApplication",
                newName: "IX_JobApplication_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_JobApplications_MessageId",
                table: "JobApplication",
                newName: "IX_JobApplication_MessageId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VideoCourse",
                table: "VideoCourse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tag",
                table: "Tag",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReportType",
                table: "ReportType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Report",
                table: "Report",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Message",
                table: "Message",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobApplication",
                table: "JobApplication",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_AspNetUsers_UserId",
                table: "JobApplication",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_Message_MessageId",
                table: "JobApplication",
                column: "MessageId",
                principalTable: "Message",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JobApplication_Post_PostId",
                table: "JobApplication",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Message_AspNetUsers_UserId",
                table: "Message",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_AspNetUsers_UserId",
                table: "Post",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_JobApplication_JobApplicationId",
                table: "Report",
                column: "JobApplicationId",
                principalTable: "JobApplication",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Report_ReportType_ReportTypeId",
                table: "Report",
                column: "ReportTypeId",
                principalTable: "ReportType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tag_Post_PostId",
                table: "Tag",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_VideoCourse_AspNetUsers_UserId",
                table: "VideoCourse",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
