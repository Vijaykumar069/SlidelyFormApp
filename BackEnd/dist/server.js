"use strict";
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
Object.defineProperty(exports, "__esModule", { value: true });
const express_1 = __importDefault(require("express"));
const fs_1 = __importDefault(require("fs"));
const path_1 = __importDefault(require("path"));
const app = (0, express_1.default)();
const PORT = 3000;
const dbPath = path_1.default.join(__dirname, 'db.json');
app.use(express_1.default.json());
// Endpoint to check if server is running
app.get('/ping', (req, res) => {
    res.json(true);
});
// Endpoint to submit a new form entry
app.post('/submit', (req, res) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;
    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).send('All fields are required.');
    }
    const newEntry = { name, email, phone, github_link, stopwatch_time };
    fs_1.default.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).send('Error reading database.');
        }
        const db = data ? JSON.parse(data) : [];
        db.push(newEntry);
        fs_1.default.writeFile(dbPath, JSON.stringify(db, null, 2), (err) => {
            if (err) {
                return res.status(500).send('Error writing to database.');
            }
            res.status(201).send('Submission successful.');
        });
    });
});
// Endpoint to read a specific form entry by index
app.get('/read', (req, res) => {
    const { index } = req.query;
    fs_1.default.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).send('Error reading database.');
        }
        const db = data ? JSON.parse(data) : [];
        if (!index || isNaN(Number(index)) || Number(index) < 0 || Number(index) >= db.length) {
            return res.status(400).send('Invalid index.');
        }
        res.json(db[Number(index)]);
    });
});
app.listen(PORT, () => {
    console.log(`Server is running on http://localhost:${PORT}`);
});
