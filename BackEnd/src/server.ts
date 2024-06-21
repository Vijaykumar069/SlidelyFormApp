import express, { Request, Response } from 'express';
import fs from 'fs';
import path from 'path';

const app = express();
const PORT = 3000;
const dbPath = path.join(__dirname, 'db.json');

app.use(express.json());

// Endpoint to check if server is running
app.get('/ping', (req: Request, res: Response) => {
    res.json(true);
});

// Endpoint to submit a new form entry
app.post('/submit', (req: Request, res: Response) => {
    const { name, email, phone, github_link, stopwatch_time } = req.body;

    if (!name || !email || !phone || !github_link || !stopwatch_time) {
        return res.status(400).send('All fields are required.');
    }

    const newEntry = { name, email, phone, github_link, stopwatch_time };

    fs.readFile(dbPath, 'utf8', (err, data) => {
        if (err) {
            return res.status(500).send('Error reading database.');
        }

        const db = data ? JSON.parse(data) : [];
        db.push(newEntry);

        fs.writeFile(dbPath, JSON.stringify(db, null, 2), (err) => {
            if (err) {
                return res.status(500).send('Error writing to database.');
            }

            res.status(201).send('Submission successful.');
        });
    });
});

// Endpoint to read a specific form entry by index
app.get('/read', (req: Request, res: Response) => {
    const { index } = req.query;

    fs.readFile(dbPath, 'utf8', (err, data) => {
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
