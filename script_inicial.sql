CREATE TABLE IF NOT EXISTS "__EFMigrationsHistory" (
    "MigrationId" TEXT NOT NULL CONSTRAINT "PK___EFMigrationsHistory" PRIMARY KEY,
    "ProductVersion" TEXT NOT NULL
);

BEGIN TRANSACTION;
CREATE TABLE "Funcionarios" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Funcionarios" PRIMARY KEY AUTOINCREMENT,
    "Nome" TEXT NOT NULL,
    "Cpf" TEXT NOT NULL,
    "Situacao" TEXT NOT NULL,
    "DataAlteracao" TEXT NOT NULL
);

CREATE TABLE "Tickets" (
    "Id" INTEGER NOT NULL CONSTRAINT "PK_Tickets" PRIMARY KEY AUTOINCREMENT,
    "FuncionarioId" INTEGER NOT NULL,
    "Quantidade" INTEGER NOT NULL,
    "Situacao" TEXT NOT NULL,
    "DataModificacao" TEXT NOT NULL,
    "FuncionarioId1" INTEGER NULL,
    CONSTRAINT "FK_Tickets_Funcionarios_FuncionarioId" FOREIGN KEY ("FuncionarioId") REFERENCES "Funcionarios" ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_Tickets_Funcionarios_FuncionarioId1" FOREIGN KEY ("FuncionarioId1") REFERENCES "Funcionarios" ("Id")
);

CREATE UNIQUE INDEX "IX_Funcionarios_Cpf" ON "Funcionarios" ("Cpf");

CREATE INDEX "IX_Tickets_FuncionarioId" ON "Tickets" ("FuncionarioId");

CREATE INDEX "IX_Tickets_FuncionarioId1" ON "Tickets" ("FuncionarioId1");

INSERT INTO "__EFMigrationsHistory" ("MigrationId", "ProductVersion")
VALUES ('20250418235255_Inicial', '9.0.4');

COMMIT;

