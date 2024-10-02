using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlowCoach.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RelationFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SelfcareArticleId",
                table: "SelfcareCards",
                newName: "SelfCareArticleId");

            migrationBuilder.RenameColumn(
                name: "CoachId",
                table: "EmotionCards",
                newName: "CoachingSessionId");

            migrationBuilder.RenameColumn(
                name: "BodyflowArticleId",
                table: "BodyFlowCards",
                newName: "BodyFlowArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_SelfcareCards_SelfCareArticleId",
                table: "SelfcareCards",
                column: "SelfCareArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmotionCards_CoachingSessionId",
                table: "EmotionCards",
                column: "CoachingSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_BodyFlowCards_BodyFlowArticleId",
                table: "BodyFlowCards",
                column: "BodyFlowArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BodyFlowCards_BodyFlowArticles_BodyFlowArticleId",
                table: "BodyFlowCards",
                column: "BodyFlowArticleId",
                principalTable: "BodyFlowArticles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmotionCards_CoachingSessions_CoachingSessionId",
                table: "EmotionCards",
                column: "CoachingSessionId",
                principalTable: "CoachingSessions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SelfcareCards_SelfcareArticles_SelfCareArticleId",
                table: "SelfcareCards",
                column: "SelfCareArticleId",
                principalTable: "SelfcareArticles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BodyFlowCards_BodyFlowArticles_BodyFlowArticleId",
                table: "BodyFlowCards");

            migrationBuilder.DropForeignKey(
                name: "FK_EmotionCards_CoachingSessions_CoachingSessionId",
                table: "EmotionCards");

            migrationBuilder.DropForeignKey(
                name: "FK_SelfcareCards_SelfcareArticles_SelfCareArticleId",
                table: "SelfcareCards");

            migrationBuilder.DropIndex(
                name: "IX_SelfcareCards_SelfCareArticleId",
                table: "SelfcareCards");

            migrationBuilder.DropIndex(
                name: "IX_EmotionCards_CoachingSessionId",
                table: "EmotionCards");

            migrationBuilder.DropIndex(
                name: "IX_BodyFlowCards_BodyFlowArticleId",
                table: "BodyFlowCards");

            migrationBuilder.RenameColumn(
                name: "SelfCareArticleId",
                table: "SelfcareCards",
                newName: "SelfcareArticleId");

            migrationBuilder.RenameColumn(
                name: "CoachingSessionId",
                table: "EmotionCards",
                newName: "CoachId");

            migrationBuilder.RenameColumn(
                name: "BodyFlowArticleId",
                table: "BodyFlowCards",
                newName: "BodyflowArticleId");
        }
    }
}
