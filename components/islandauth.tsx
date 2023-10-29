'use client'
import Box from '@mui/material/Box';
import Modal from '@mui/material/Modal';
import Button from '@mui/material/Button';
import { styled } from '@mui/system';
import { useEffect, useState } from 'react';
import { FormControl } from '@mui/material';
import { Form } from './form';
import axios from 'axios';
import { TYPES } from 'pixijs';




function ChildModal(){
    const [open, setOpen] = useState<boolean>(false);
    const handleOpen = () => {
      setOpen(true);
    };
    const handleClose = () => {
      setOpen(false);
    };
    return(
        <div>
            <Button onClick={handleOpen}>Авторизация</Button>
            <Modal
                className='modal'
                open={open}
                onClose={handleClose}
                aria-labelledby="child-modal-title"
                aria-describedby="child-modal-description"
            >
            <Box className="modal-box">
                <div className="modal-pos">
                    <h2 id="parent-modal-title">Авторизация</h2>
                    <p>Номер телефона</p>
                    <Form/>
                    <p>Пароль</p>
                    <Form/>
                    <Btn type="submit" onClick={(e) => {console.log('fff')}}>sub</Btn>
                </div>
            <Button onClick={handleClose}>Регистрация</Button>
            </Box>
        </Modal>
        </div>
    )
}
const bc = {
    100: '#DAECFF',
}
const Btn = styled(Button)(
    `
        margin-top: 10px;
    `
)
const Auth = () => {
//   'https://localhost:7134/api'
    const [appState, setAppState] = useState<any>();
    
    useEffect(() => {
   
    }, [setAppState]);
    const [open, setOpen] = useState<boolean>(false);
    const handleOpen = () => {
        setOpen(true);
    };
    const handleClose = () => {
        setOpen(false);
    };
    function sub(){
        const apiUrl = 'https://localhost:7134/api';
        axios.get(apiUrl).then((resp) => {
            const allPersons = resp;
            setAppState(allPersons);
        });
        console.log(appState)
    }
    return(
        <div>
            <Button onClick={handleOpen}>Login / Auth</Button>
            <Modal
                open={open}
                onClose={handleClose}
                aria-labelledby="parent-modal-title"
                aria-describedby="parent-modal-description"
            >
                <Box className="modal-box" >
                    <div className="modal-pos">
                        <h2 id="parent-modal-title">Регистрация</h2>
                        <p>Номер телефона</p>
                        <Form/>
                        <p>Никнейм</p>
                        <Form/>
                        <p>Фио</p>
                        <Form/>
                        <Btn type="submit" onClick={sub}>sub</Btn>
                    </div>
                <ChildModal />
                </Box>
            </Modal>
        </div>
    )
}

export { Auth }