-- MySQL Script generated by MySQL Workbench
-- Thu Mar 17 16:17:37 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema ProgramacionEjercicio3
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema ProgramacionEjercicio3
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `ProgramacionEjercicio3` DEFAULT CHARACTER SET utf8 ;
USE `ProgramacionEjercicio3` ;

-- -----------------------------------------------------
-- Table `ProgramacionEjercicio3`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `ProgramacionEjercicio3`.`Usuario` (
  `Codigo` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(45) NOT NULL,
  `Tipo Usuario` VARCHAR(15) NULL,
  `Celular` VARCHAR(45) NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
