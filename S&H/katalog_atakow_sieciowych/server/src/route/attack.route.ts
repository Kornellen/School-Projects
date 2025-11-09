import { Router } from "express";
import { AttackController } from "../controller/attack.controller";

/**
 *  Dodawanie ścieżek do API
 */

const attackRouter = Router();

const attackController = new AttackController();

attackRouter.get("/attack", attackController.getAttack);

attackRouter.get("/attacks", attackController.getAttacks);

export default attackRouter;
