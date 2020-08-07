using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class FixMachineId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineID",
                table: "EngineerMachine");

            migrationBuilder.RenameColumn(
                name: "MachineID",
                table: "EngineerMachine",
                newName: "MachineId");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_MachineID",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_MachineId");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EngineerMachine_Machines_MachineId",
                table: "EngineerMachine");

            migrationBuilder.RenameColumn(
                name: "MachineId",
                table: "EngineerMachine",
                newName: "MachineID");

            migrationBuilder.RenameIndex(
                name: "IX_EngineerMachine_MachineId",
                table: "EngineerMachine",
                newName: "IX_EngineerMachine_MachineID");

            migrationBuilder.AddForeignKey(
                name: "FK_EngineerMachine_Machines_MachineID",
                table: "EngineerMachine",
                column: "MachineID",
                principalTable: "Machines",
                principalColumn: "MachineId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
