﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RickAndMorty.WebApi.Migrations
{
    /// <inheritdoc />
    public partial class mg2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCharacters_Episodes_EpisodeId",
                table: "EpisodeCharacters");

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCharacters_Episodes_EpisodeId",
                table: "EpisodeCharacters",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EpisodeCharacters_Episodes_EpisodeId",
                table: "EpisodeCharacters");

            migrationBuilder.AddForeignKey(
                name: "FK_EpisodeCharacters_Episodes_EpisodeId",
                table: "EpisodeCharacters",
                column: "EpisodeId",
                principalTable: "Episodes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
