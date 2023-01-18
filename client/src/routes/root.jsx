import { TextField, MenuItem, Button } from "@mui/material";
import SendIcon from '@mui/icons-material/Send';
import { Link, redirect, useNavigate } from "react-router-dom";
import { useState } from "react";

const regions = [
  {
    value: 'EUW1',
    label: 'EUW',
  },
  {
    value: 'EUNE1',
    label: 'EUNE',
  },
  {
    value: 'RU1',
    label: 'RU',
  },
  {
    value: 'NA1',
    label: 'NA',
  },
];

export default function Root() {
  const navigate = useNavigate();
  const [summonerName, setSummonerName] = useState("");
  const [region, setRegion] = useState(regions[0].value);

  function updateSummonerName(e) { setSummonerName(e.target.value); }
  function updateRegion(e) { setRegion(e.target.value); }

  function handleClick() { navigate(`/${region}/summoner/${summonerName}`); }

  return (
    <>
      <div>
        <h1>Find profile</h1>
      </div>
      <div>
        <TextField id="outlined-basic" label="Summoner name" variant="outlined" size="small" onChange={updateSummonerName} />
        <TextField
          id="outlined-select-currency"
          select
          label="Region"
          defaultValue="euw1"
          helperText="Select region"
          size="small"
          onChange={updateRegion}
        >
          {regions.map((option) => (
            <MenuItem key={option.value} value={option.value}>
              {option.label}
            </MenuItem>
          ))}
        </TextField>
        <Button onClick={handleClick} variant="contained" endIcon={<SendIcon />}>
          Find
        </Button>
      </div>
    </>
  );
}